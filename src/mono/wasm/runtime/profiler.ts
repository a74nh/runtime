// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

import { ENVIRONMENT_IS_WEB, Module, runtimeHelpers } from "./imports";
import { AOTProfilerOptions, BrowserProfilerOptions } from "./types";
import cwraps from "./cwraps";
import { MonoMethod } from "./types";

// Initialize the AOT profiler with OPTIONS.
// Requires the AOT profiler to be linked into the app.
// options = { writeAt: "<METHODNAME>", sendTo: "<METHODNAME>" }
// <METHODNAME> should be in the format <CLASS>::<METHODNAME>.
// writeAt defaults to 'WebAssembly.Runtime::StopProfile'.
// sendTo defaults to 'WebAssembly.Runtime::DumpAotProfileData'.
// DumpAotProfileData stores the data into INTERNAL.aotProfileData.
//
export function mono_wasm_init_aot_profiler(options: AOTProfilerOptions): void {
    if (options == null)
        options = {};
    if (!("writeAt" in options))
        options.writeAt = "System.Runtime.InteropServices.JavaScript.JavaScriptExports::StopProfile";
    if (!("sendTo" in options))
        options.sendTo = "Interop/Runtime::DumpAotProfileData";
    const arg = "aot:write-at-method=" + options.writeAt + ",send-to-method=" + options.sendTo;
    cwraps.mono_wasm_profiler_init_aot(arg);
}

export function mono_wasm_init_browser_profiler(options: BrowserProfilerOptions): void {
    if (options == null)
        options = {};
    const arg = "browser:";
    cwraps.mono_wasm_profiler_init_browser(arg);
}

export const enum MeasuredBlock {
    emscriptenStartup = "mono.emscriptenStartup",
    instantiateWasm = "mono.instantiateWasm",
    preInit = "mono.preInit",
    preInitWorker = "mono.preInitWorker",
    preRun = "mono.preRun",
    preRunWorker = "mono.preRunWorker",
    onRuntimeInitialized = "mono.onRuntimeInitialized",
    postRun = "mono.postRun",
    loadRuntime = "mono.loadRuntime",
    bindingsInit = "mono.bindingsInit",
    bindJsFunction = "mono.bindJsFunction:",
    bindCsFunction = "mono.bindCsFunction:",
    callJsFunction = "mono.callJsFunction:",
    callCsFunction = "mono.callCsFunction:",
    getAssemblyExports = "mono.getAssemblyExports:",
    instantiateAsset = "mono.instantiateAsset:",
}

export type TimeStamp = {
    __brand: "TimeStamp"
}



export function startMeasure(): TimeStamp {
    if (runtimeHelpers.enablePerfMeasure) {
        return globalThis.performance.now() as any;
    }
    return undefined as any;
}

export function endMeasure(start: TimeStamp, block: string, id?: string) {
    if (runtimeHelpers.enablePerfMeasure && start) {
        const options = ENVIRONMENT_IS_WEB
            ? { start: start as any }
            : { startTime: start as any };
        const name = id ? `${block}${id} ` : block;
        globalThis.performance.measure(name, options);
    }
}

const stackFrames: number[] = [];
export function mono_wasm_profiler_enter(): void {
    if (runtimeHelpers.enablePerfMeasure) {
        stackFrames.push(globalThis.performance.now());
    }
}

const methodNames: Map<number, string> = new Map();
export function mono_wasm_profiler_leave(method: MonoMethod): void {
    if (runtimeHelpers.enablePerfMeasure) {
        const start = stackFrames.pop();
        const options = ENVIRONMENT_IS_WEB
            ? { start: start }
            : { startTime: start };
        let methodName = methodNames.get(method as any);
        if (!methodName) {
            const chars = cwraps.mono_wasm_method_get_name(method);
            methodName = Module.UTF8ToString(chars);
            methodNames.set(method as any, methodName);
        }
        globalThis.performance.measure(methodName, options);
    }
}
