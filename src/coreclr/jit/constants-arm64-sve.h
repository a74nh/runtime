// Copyright 2015, VIXL authors
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are met:
//
//   * Redistributions of source code must retain the above copyright notice,
//     this list of conditions and the following disclaimer.
//   * Redistributions in binary form must reproduce the above copyright notice,
//     this list of conditions and the following disclaimer in the documentation
//     and/or other materials provided with the distribution.
//   * Neither the name of ARM Limited nor the names of its contributors may be
//     used to endorse or promote products derived from this software without
//     specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE
// FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
// CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
// OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

#ifndef VIXL_AARCH64_CONSTANTS_AARCH64_H_
#define VIXL_AARCH64_CONSTANTS_AARCH64_H_

// clang-format off

enum SVE32BitGatherLoadHalfwords_ScalarPlus32BitScaledOffsetsOp {
  SVE32BitGatherLoadHalfwords_ScalarPlus32BitScaledOffsetsFixed = 0x84A00000,
  SVE32BitGatherLoadHalfwords_ScalarPlus32BitScaledOffsetsFMask = 0xFFA08000,
  SVE32BitGatherLoadHalfwords_ScalarPlus32BitScaledOffsetsMask = 0xFFA0E000,
  LD1SH_z_p_bz_s_x32_scaled = SVE32BitGatherLoadHalfwords_ScalarPlus32BitScaledOffsetsFixed,
  LDFF1SH_z_p_bz_s_x32_scaled = SVE32BitGatherLoadHalfwords_ScalarPlus32BitScaledOffsetsFixed | 0x00002000,
  LD1H_z_p_bz_s_x32_scaled = SVE32BitGatherLoadHalfwords_ScalarPlus32BitScaledOffsetsFixed | 0x00004000,
  LDFF1H_z_p_bz_s_x32_scaled = SVE32BitGatherLoadHalfwords_ScalarPlus32BitScaledOffsetsFixed | 0x00006000
};

enum SVE32BitGatherLoadWords_ScalarPlus32BitScaledOffsetsOp {
  SVE32BitGatherLoadWords_ScalarPlus32BitScaledOffsetsFixed = 0x85200000,
  SVE32BitGatherLoadWords_ScalarPlus32BitScaledOffsetsFMask = 0xFFA08000,
  SVE32BitGatherLoadWords_ScalarPlus32BitScaledOffsetsMask = 0xFFA0E000,
  LD1W_z_p_bz_s_x32_scaled = SVE32BitGatherLoadWords_ScalarPlus32BitScaledOffsetsFixed | 0x00004000,
  LDFF1W_z_p_bz_s_x32_scaled = SVE32BitGatherLoadWords_ScalarPlus32BitScaledOffsetsFixed | 0x00006000
};

enum SVE32BitGatherLoad_ScalarPlus32BitUnscaledOffsetsOp {
  SVE32BitGatherLoad_ScalarPlus32BitUnscaledOffsetsFixed = 0x84000000,
  SVE32BitGatherLoad_ScalarPlus32BitUnscaledOffsetsFMask = 0xFE208000,
  SVE32BitGatherLoad_ScalarPlus32BitUnscaledOffsetsMask = 0xFFA0E000,
  LD1SB_z_p_bz_s_x32_unscaled = SVE32BitGatherLoad_ScalarPlus32BitUnscaledOffsetsFixed,
  LDFF1SB_z_p_bz_s_x32_unscaled = SVE32BitGatherLoad_ScalarPlus32BitUnscaledOffsetsFixed | 0x00002000,
  LD1B_z_p_bz_s_x32_unscaled = SVE32BitGatherLoad_ScalarPlus32BitUnscaledOffsetsFixed | 0x00004000,
  LDFF1B_z_p_bz_s_x32_unscaled = SVE32BitGatherLoad_ScalarPlus32BitUnscaledOffsetsFixed | 0x00006000,
  LD1SH_z_p_bz_s_x32_unscaled = SVE32BitGatherLoad_ScalarPlus32BitUnscaledOffsetsFixed | 0x00800000,
  LDFF1SH_z_p_bz_s_x32_unscaled = SVE32BitGatherLoad_ScalarPlus32BitUnscaledOffsetsFixed | 0x00802000,
  LD1H_z_p_bz_s_x32_unscaled = SVE32BitGatherLoad_ScalarPlus32BitUnscaledOffsetsFixed | 0x00804000,
  LDFF1H_z_p_bz_s_x32_unscaled = SVE32BitGatherLoad_ScalarPlus32BitUnscaledOffsetsFixed | 0x00806000,
  LD1W_z_p_bz_s_x32_unscaled = SVE32BitGatherLoad_ScalarPlus32BitUnscaledOffsetsFixed | 0x01004000,
  LDFF1W_z_p_bz_s_x32_unscaled = SVE32BitGatherLoad_ScalarPlus32BitUnscaledOffsetsFixed | 0x01006000
};

enum SVE32BitGatherLoad_VectorPlusImmOp {
  SVE32BitGatherLoad_VectorPlusImmFixed = 0x84208000,
  SVE32BitGatherLoad_VectorPlusImmFMask = 0xFE608000,
  SVE32BitGatherLoad_VectorPlusImmMask = 0xFFE0E000,
  LD1SB_z_p_ai_s = SVE32BitGatherLoad_VectorPlusImmFixed,
  LDFF1SB_z_p_ai_s = SVE32BitGatherLoad_VectorPlusImmFixed | 0x00002000,
  LD1B_z_p_ai_s = SVE32BitGatherLoad_VectorPlusImmFixed | 0x00004000,
  LDFF1B_z_p_ai_s = SVE32BitGatherLoad_VectorPlusImmFixed | 0x00006000,
  LD1SH_z_p_ai_s = SVE32BitGatherLoad_VectorPlusImmFixed | 0x00800000,
  LDFF1SH_z_p_ai_s = SVE32BitGatherLoad_VectorPlusImmFixed | 0x00802000,
  LD1H_z_p_ai_s = SVE32BitGatherLoad_VectorPlusImmFixed | 0x00804000,
  LDFF1H_z_p_ai_s = SVE32BitGatherLoad_VectorPlusImmFixed | 0x00806000,
  LD1W_z_p_ai_s = SVE32BitGatherLoad_VectorPlusImmFixed | 0x01004000,
  LDFF1W_z_p_ai_s = SVE32BitGatherLoad_VectorPlusImmFixed | 0x01006000
};

enum SVE32BitGatherPrefetch_ScalarPlus32BitScaledOffsetsOp {
  SVE32BitGatherPrefetch_ScalarPlus32BitScaledOffsetsFixed = 0x84200000,
  SVE32BitGatherPrefetch_ScalarPlus32BitScaledOffsetsFMask = 0xFFA08010,
  SVE32BitGatherPrefetch_ScalarPlus32BitScaledOffsetsMask = 0xFFA0E010,
  PRFB_i_p_bz_s_x32_scaled = SVE32BitGatherPrefetch_ScalarPlus32BitScaledOffsetsFixed,
  PRFH_i_p_bz_s_x32_scaled = SVE32BitGatherPrefetch_ScalarPlus32BitScaledOffsetsFixed | 0x00002000,
  PRFW_i_p_bz_s_x32_scaled = SVE32BitGatherPrefetch_ScalarPlus32BitScaledOffsetsFixed | 0x00004000,
  PRFD_i_p_bz_s_x32_scaled = SVE32BitGatherPrefetch_ScalarPlus32BitScaledOffsetsFixed | 0x00006000
};

enum SVE32BitGatherPrefetch_VectorPlusImmOp {
  SVE32BitGatherPrefetch_VectorPlusImmFixed = 0x8400E000,
  SVE32BitGatherPrefetch_VectorPlusImmFMask = 0xFE60E010,
  SVE32BitGatherPrefetch_VectorPlusImmMask = 0xFFE0E010,
  PRFB_i_p_ai_s = SVE32BitGatherPrefetch_VectorPlusImmFixed,
  PRFH_i_p_ai_s = SVE32BitGatherPrefetch_VectorPlusImmFixed | 0x00800000,
  PRFW_i_p_ai_s = SVE32BitGatherPrefetch_VectorPlusImmFixed | 0x01000000,
  PRFD_i_p_ai_s = SVE32BitGatherPrefetch_VectorPlusImmFixed | 0x01800000
};

enum SVE32BitScatterStore_ScalarPlus32BitScaledOffsetsOp {
  SVE32BitScatterStore_ScalarPlus32BitScaledOffsetsFixed = 0xE4608000,
  SVE32BitScatterStore_ScalarPlus32BitScaledOffsetsFMask = 0xFE60A000,
  SVE32BitScatterStore_ScalarPlus32BitScaledOffsetsMask = 0xFFE0A000,
  ST1H_z_p_bz_s_x32_scaled = SVE32BitScatterStore_ScalarPlus32BitScaledOffsetsFixed | 0x00800000,
  ST1W_z_p_bz_s_x32_scaled = SVE32BitScatterStore_ScalarPlus32BitScaledOffsetsFixed | 0x01000000
};

enum SVE32BitScatterStore_ScalarPlus32BitUnscaledOffsetsOp {
  SVE32BitScatterStore_ScalarPlus32BitUnscaledOffsetsFixed = 0xE4408000,
  SVE32BitScatterStore_ScalarPlus32BitUnscaledOffsetsFMask = 0xFE60A000,
  SVE32BitScatterStore_ScalarPlus32BitUnscaledOffsetsMask = 0xFFE0A000,
  ST1B_z_p_bz_s_x32_unscaled = SVE32BitScatterStore_ScalarPlus32BitUnscaledOffsetsFixed,
  ST1H_z_p_bz_s_x32_unscaled = SVE32BitScatterStore_ScalarPlus32BitUnscaledOffsetsFixed | 0x00800000,
  ST1W_z_p_bz_s_x32_unscaled = SVE32BitScatterStore_ScalarPlus32BitUnscaledOffsetsFixed | 0x01000000
};

enum SVE32BitScatterStore_VectorPlusImmOp {
  SVE32BitScatterStore_VectorPlusImmFixed = 0xE460A000,
  SVE32BitScatterStore_VectorPlusImmFMask = 0xFE60E000,
  SVE32BitScatterStore_VectorPlusImmMask = 0xFFE0E000,
  ST1B_z_p_ai_s = SVE32BitScatterStore_VectorPlusImmFixed,
  ST1H_z_p_ai_s = SVE32BitScatterStore_VectorPlusImmFixed | 0x00800000,
  ST1W_z_p_ai_s = SVE32BitScatterStore_VectorPlusImmFixed | 0x01000000
};

enum SVE64BitGatherLoad_ScalarPlus32BitUnpackedScaledOffsetsOp {
  SVE64BitGatherLoad_ScalarPlus32BitUnpackedScaledOffsetsFixed = 0xC4200000,
  SVE64BitGatherLoad_ScalarPlus32BitUnpackedScaledOffsetsFMask = 0xFE208000,
  SVE64BitGatherLoad_ScalarPlus32BitUnpackedScaledOffsetsMask = 0xFFA0E000,
  LD1SH_z_p_bz_d_x32_scaled = SVE64BitGatherLoad_ScalarPlus32BitUnpackedScaledOffsetsFixed | 0x00800000,
  LDFF1SH_z_p_bz_d_x32_scaled = SVE64BitGatherLoad_ScalarPlus32BitUnpackedScaledOffsetsFixed | 0x00802000,
  LD1H_z_p_bz_d_x32_scaled = SVE64BitGatherLoad_ScalarPlus32BitUnpackedScaledOffsetsFixed | 0x00804000,
  LDFF1H_z_p_bz_d_x32_scaled = SVE64BitGatherLoad_ScalarPlus32BitUnpackedScaledOffsetsFixed | 0x00806000,
  LD1SW_z_p_bz_d_x32_scaled = SVE64BitGatherLoad_ScalarPlus32BitUnpackedScaledOffsetsFixed | 0x01000000,
  LDFF1SW_z_p_bz_d_x32_scaled = SVE64BitGatherLoad_ScalarPlus32BitUnpackedScaledOffsetsFixed | 0x01002000,
  LD1W_z_p_bz_d_x32_scaled = SVE64BitGatherLoad_ScalarPlus32BitUnpackedScaledOffsetsFixed | 0x01004000,
  LDFF1W_z_p_bz_d_x32_scaled = SVE64BitGatherLoad_ScalarPlus32BitUnpackedScaledOffsetsFixed | 0x01006000,
  LD1D_z_p_bz_d_x32_scaled = SVE64BitGatherLoad_ScalarPlus32BitUnpackedScaledOffsetsFixed | 0x01804000,
  LDFF1D_z_p_bz_d_x32_scaled = SVE64BitGatherLoad_ScalarPlus32BitUnpackedScaledOffsetsFixed | 0x01806000
};

enum SVE64BitGatherLoad_ScalarPlus64BitScaledOffsetsOp {
  SVE64BitGatherLoad_ScalarPlus64BitScaledOffsetsFixed = 0xC4608000,
  SVE64BitGatherLoad_ScalarPlus64BitScaledOffsetsFMask = 0xFE608000,
  SVE64BitGatherLoad_ScalarPlus64BitScaledOffsetsMask = 0xFFE0E000,
  LD1SH_z_p_bz_d_64_scaled = SVE64BitGatherLoad_ScalarPlus64BitScaledOffsetsFixed | 0x00800000,
  LDFF1SH_z_p_bz_d_64_scaled = SVE64BitGatherLoad_ScalarPlus64BitScaledOffsetsFixed | 0x00802000,
  LD1H_z_p_bz_d_64_scaled = SVE64BitGatherLoad_ScalarPlus64BitScaledOffsetsFixed | 0x00804000,
  LDFF1H_z_p_bz_d_64_scaled = SVE64BitGatherLoad_ScalarPlus64BitScaledOffsetsFixed | 0x00806000,
  LD1SW_z_p_bz_d_64_scaled = SVE64BitGatherLoad_ScalarPlus64BitScaledOffsetsFixed | 0x01000000,
  LDFF1SW_z_p_bz_d_64_scaled = SVE64BitGatherLoad_ScalarPlus64BitScaledOffsetsFixed | 0x01002000,
  LD1W_z_p_bz_d_64_scaled = SVE64BitGatherLoad_ScalarPlus64BitScaledOffsetsFixed | 0x01004000,
  LDFF1W_z_p_bz_d_64_scaled = SVE64BitGatherLoad_ScalarPlus64BitScaledOffsetsFixed | 0x01006000,
  LD1D_z_p_bz_d_64_scaled = SVE64BitGatherLoad_ScalarPlus64BitScaledOffsetsFixed | 0x01804000,
  LDFF1D_z_p_bz_d_64_scaled = SVE64BitGatherLoad_ScalarPlus64BitScaledOffsetsFixed | 0x01806000
};

enum SVE64BitGatherLoad_ScalarPlus64BitUnscaledOffsetsOp {
  SVE64BitGatherLoad_ScalarPlus64BitUnscaledOffsetsFixed = 0xC4408000,
  SVE64BitGatherLoad_ScalarPlus64BitUnscaledOffsetsFMask = 0xFE608000,
  SVE64BitGatherLoad_ScalarPlus64BitUnscaledOffsetsMask = 0xFFE0E000,
  LD1SB_z_p_bz_d_64_unscaled = SVE64BitGatherLoad_ScalarPlus64BitUnscaledOffsetsFixed,
  LDFF1SB_z_p_bz_d_64_unscaled = SVE64BitGatherLoad_ScalarPlus64BitUnscaledOffsetsFixed | 0x00002000,
  LD1B_z_p_bz_d_64_unscaled = SVE64BitGatherLoad_ScalarPlus64BitUnscaledOffsetsFixed | 0x00004000,
  LDFF1B_z_p_bz_d_64_unscaled = SVE64BitGatherLoad_ScalarPlus64BitUnscaledOffsetsFixed | 0x00006000,
  LD1SH_z_p_bz_d_64_unscaled = SVE64BitGatherLoad_ScalarPlus64BitUnscaledOffsetsFixed | 0x00800000,
  LDFF1SH_z_p_bz_d_64_unscaled = SVE64BitGatherLoad_ScalarPlus64BitUnscaledOffsetsFixed | 0x00802000,
  LD1H_z_p_bz_d_64_unscaled = SVE64BitGatherLoad_ScalarPlus64BitUnscaledOffsetsFixed | 0x00804000,
  LDFF1H_z_p_bz_d_64_unscaled = SVE64BitGatherLoad_ScalarPlus64BitUnscaledOffsetsFixed | 0x00806000,
  LD1SW_z_p_bz_d_64_unscaled = SVE64BitGatherLoad_ScalarPlus64BitUnscaledOffsetsFixed | 0x01000000,
  LDFF1SW_z_p_bz_d_64_unscaled = SVE64BitGatherLoad_ScalarPlus64BitUnscaledOffsetsFixed | 0x01002000,
  LD1W_z_p_bz_d_64_unscaled = SVE64BitGatherLoad_ScalarPlus64BitUnscaledOffsetsFixed | 0x01004000,
  LDFF1W_z_p_bz_d_64_unscaled = SVE64BitGatherLoad_ScalarPlus64BitUnscaledOffsetsFixed | 0x01006000,
  LD1D_z_p_bz_d_64_unscaled = SVE64BitGatherLoad_ScalarPlus64BitUnscaledOffsetsFixed | 0x01804000,
  LDFF1D_z_p_bz_d_64_unscaled = SVE64BitGatherLoad_ScalarPlus64BitUnscaledOffsetsFixed | 0x01806000
};

enum SVE64BitGatherLoad_ScalarPlusUnpacked32BitUnscaledOffsetsOp {
  SVE64BitGatherLoad_ScalarPlusUnpacked32BitUnscaledOffsetsFixed = 0xC4000000,
  SVE64BitGatherLoad_ScalarPlusUnpacked32BitUnscaledOffsetsFMask = 0xFE208000,
  SVE64BitGatherLoad_ScalarPlusUnpacked32BitUnscaledOffsetsMask = 0xFFA0E000,
  LD1SB_z_p_bz_d_x32_unscaled = SVE64BitGatherLoad_ScalarPlusUnpacked32BitUnscaledOffsetsFixed,
  LDFF1SB_z_p_bz_d_x32_unscaled = SVE64BitGatherLoad_ScalarPlusUnpacked32BitUnscaledOffsetsFixed | 0x00002000,
  LD1B_z_p_bz_d_x32_unscaled = SVE64BitGatherLoad_ScalarPlusUnpacked32BitUnscaledOffsetsFixed | 0x00004000,
  LDFF1B_z_p_bz_d_x32_unscaled = SVE64BitGatherLoad_ScalarPlusUnpacked32BitUnscaledOffsetsFixed | 0x00006000,
  LD1SH_z_p_bz_d_x32_unscaled = SVE64BitGatherLoad_ScalarPlusUnpacked32BitUnscaledOffsetsFixed | 0x00800000,
  LDFF1SH_z_p_bz_d_x32_unscaled = SVE64BitGatherLoad_ScalarPlusUnpacked32BitUnscaledOffsetsFixed | 0x00802000,
  LD1H_z_p_bz_d_x32_unscaled = SVE64BitGatherLoad_ScalarPlusUnpacked32BitUnscaledOffsetsFixed | 0x00804000,
  LDFF1H_z_p_bz_d_x32_unscaled = SVE64BitGatherLoad_ScalarPlusUnpacked32BitUnscaledOffsetsFixed | 0x00806000,
  LD1SW_z_p_bz_d_x32_unscaled = SVE64BitGatherLoad_ScalarPlusUnpacked32BitUnscaledOffsetsFixed | 0x01000000,
  LDFF1SW_z_p_bz_d_x32_unscaled = SVE64BitGatherLoad_ScalarPlusUnpacked32BitUnscaledOffsetsFixed | 0x01002000,
  LD1W_z_p_bz_d_x32_unscaled = SVE64BitGatherLoad_ScalarPlusUnpacked32BitUnscaledOffsetsFixed | 0x01004000,
  LDFF1W_z_p_bz_d_x32_unscaled = SVE64BitGatherLoad_ScalarPlusUnpacked32BitUnscaledOffsetsFixed | 0x01006000,
  LD1D_z_p_bz_d_x32_unscaled = SVE64BitGatherLoad_ScalarPlusUnpacked32BitUnscaledOffsetsFixed | 0x01804000,
  LDFF1D_z_p_bz_d_x32_unscaled = SVE64BitGatherLoad_ScalarPlusUnpacked32BitUnscaledOffsetsFixed | 0x01806000
};

enum SVE64BitGatherLoad_VectorPlusImmOp {
  SVE64BitGatherLoad_VectorPlusImmFixed = 0xC4208000,
  SVE64BitGatherLoad_VectorPlusImmFMask = 0xFE608000,
  SVE64BitGatherLoad_VectorPlusImmMask = 0xFFE0E000,
  LD1SB_z_p_ai_d = SVE64BitGatherLoad_VectorPlusImmFixed,
  LDFF1SB_z_p_ai_d = SVE64BitGatherLoad_VectorPlusImmFixed | 0x00002000,
  LD1B_z_p_ai_d = SVE64BitGatherLoad_VectorPlusImmFixed | 0x00004000,
  LDFF1B_z_p_ai_d = SVE64BitGatherLoad_VectorPlusImmFixed | 0x00006000,
  LD1SH_z_p_ai_d = SVE64BitGatherLoad_VectorPlusImmFixed | 0x00800000,
  LDFF1SH_z_p_ai_d = SVE64BitGatherLoad_VectorPlusImmFixed | 0x00802000,
  LD1H_z_p_ai_d = SVE64BitGatherLoad_VectorPlusImmFixed | 0x00804000,
  LDFF1H_z_p_ai_d = SVE64BitGatherLoad_VectorPlusImmFixed | 0x00806000,
  LD1SW_z_p_ai_d = SVE64BitGatherLoad_VectorPlusImmFixed | 0x01000000,
  LDFF1SW_z_p_ai_d = SVE64BitGatherLoad_VectorPlusImmFixed | 0x01002000,
  LD1W_z_p_ai_d = SVE64BitGatherLoad_VectorPlusImmFixed | 0x01004000,
  LDFF1W_z_p_ai_d = SVE64BitGatherLoad_VectorPlusImmFixed | 0x01006000,
  LD1D_z_p_ai_d = SVE64BitGatherLoad_VectorPlusImmFixed | 0x01804000,
  LDFF1D_z_p_ai_d = SVE64BitGatherLoad_VectorPlusImmFixed | 0x01806000
};

enum SVE64BitGatherPrefetch_ScalarPlus64BitScaledOffsetsOp {
  SVE64BitGatherPrefetch_ScalarPlus64BitScaledOffsetsFixed = 0xC4608000,
  SVE64BitGatherPrefetch_ScalarPlus64BitScaledOffsetsFMask = 0xFFE08010,
  SVE64BitGatherPrefetch_ScalarPlus64BitScaledOffsetsMask = 0xFFE0E010,
  PRFB_i_p_bz_d_64_scaled = SVE64BitGatherPrefetch_ScalarPlus64BitScaledOffsetsFixed,
  PRFH_i_p_bz_d_64_scaled = SVE64BitGatherPrefetch_ScalarPlus64BitScaledOffsetsFixed | 0x00002000,
  PRFW_i_p_bz_d_64_scaled = SVE64BitGatherPrefetch_ScalarPlus64BitScaledOffsetsFixed | 0x00004000,
  PRFD_i_p_bz_d_64_scaled = SVE64BitGatherPrefetch_ScalarPlus64BitScaledOffsetsFixed | 0x00006000
};

enum SVE64BitGatherPrefetch_ScalarPlusUnpacked32BitScaledOffsetsOp {
  SVE64BitGatherPrefetch_ScalarPlusUnpacked32BitScaledOffsetsFixed = 0xC4200000,
  SVE64BitGatherPrefetch_ScalarPlusUnpacked32BitScaledOffsetsFMask = 0xFFA08010,
  SVE64BitGatherPrefetch_ScalarPlusUnpacked32BitScaledOffsetsMask = 0xFFA0E010,
  PRFB_i_p_bz_d_x32_scaled = SVE64BitGatherPrefetch_ScalarPlusUnpacked32BitScaledOffsetsFixed,
  PRFH_i_p_bz_d_x32_scaled = SVE64BitGatherPrefetch_ScalarPlusUnpacked32BitScaledOffsetsFixed | 0x00002000,
  PRFW_i_p_bz_d_x32_scaled = SVE64BitGatherPrefetch_ScalarPlusUnpacked32BitScaledOffsetsFixed | 0x00004000,
  PRFD_i_p_bz_d_x32_scaled = SVE64BitGatherPrefetch_ScalarPlusUnpacked32BitScaledOffsetsFixed | 0x00006000
};

enum SVE64BitGatherPrefetch_VectorPlusImmOp {
  SVE64BitGatherPrefetch_VectorPlusImmFixed = 0xC400E000,
  SVE64BitGatherPrefetch_VectorPlusImmFMask = 0xFE60E010,
  SVE64BitGatherPrefetch_VectorPlusImmMask = 0xFFE0E010,
  PRFB_i_p_ai_d = SVE64BitGatherPrefetch_VectorPlusImmFixed,
  PRFH_i_p_ai_d = SVE64BitGatherPrefetch_VectorPlusImmFixed | 0x00800000,
  PRFW_i_p_ai_d = SVE64BitGatherPrefetch_VectorPlusImmFixed | 0x01000000,
  PRFD_i_p_ai_d = SVE64BitGatherPrefetch_VectorPlusImmFixed | 0x01800000
};

enum SVE64BitScatterStore_ScalarPlus64BitScaledOffsetsOp {
  SVE64BitScatterStore_ScalarPlus64BitScaledOffsetsFixed = 0xE420A000,
  SVE64BitScatterStore_ScalarPlus64BitScaledOffsetsFMask = 0xFE60E000,
  SVE64BitScatterStore_ScalarPlus64BitScaledOffsetsMask = 0xFFE0E000,
  ST1H_z_p_bz_d_64_scaled = SVE64BitScatterStore_ScalarPlus64BitScaledOffsetsFixed | 0x00800000,
  ST1W_z_p_bz_d_64_scaled = SVE64BitScatterStore_ScalarPlus64BitScaledOffsetsFixed | 0x01000000,
  ST1D_z_p_bz_d_64_scaled = SVE64BitScatterStore_ScalarPlus64BitScaledOffsetsFixed | 0x01800000
};

enum SVE64BitScatterStore_ScalarPlus64BitUnscaledOffsetsOp {
  SVE64BitScatterStore_ScalarPlus64BitUnscaledOffsetsFixed = 0xE400A000,
  SVE64BitScatterStore_ScalarPlus64BitUnscaledOffsetsFMask = 0xFE60E000,
  SVE64BitScatterStore_ScalarPlus64BitUnscaledOffsetsMask = 0xFFE0E000,
  ST1B_z_p_bz_d_64_unscaled = SVE64BitScatterStore_ScalarPlus64BitUnscaledOffsetsFixed,
  ST1H_z_p_bz_d_64_unscaled = SVE64BitScatterStore_ScalarPlus64BitUnscaledOffsetsFixed | 0x00800000,
  ST1W_z_p_bz_d_64_unscaled = SVE64BitScatterStore_ScalarPlus64BitUnscaledOffsetsFixed | 0x01000000,
  ST1D_z_p_bz_d_64_unscaled = SVE64BitScatterStore_ScalarPlus64BitUnscaledOffsetsFixed | 0x01800000
};

enum SVE64BitScatterStore_ScalarPlusUnpacked32BitScaledOffsetsOp {
  SVE64BitScatterStore_ScalarPlusUnpacked32BitScaledOffsetsFixed = 0xE4208000,
  SVE64BitScatterStore_ScalarPlusUnpacked32BitScaledOffsetsFMask = 0xFE60A000,
  SVE64BitScatterStore_ScalarPlusUnpacked32BitScaledOffsetsMask = 0xFFE0A000,
  ST1H_z_p_bz_d_x32_scaled = SVE64BitScatterStore_ScalarPlusUnpacked32BitScaledOffsetsFixed | 0x00800000,
  ST1W_z_p_bz_d_x32_scaled = SVE64BitScatterStore_ScalarPlusUnpacked32BitScaledOffsetsFixed | 0x01000000,
  ST1D_z_p_bz_d_x32_scaled = SVE64BitScatterStore_ScalarPlusUnpacked32BitScaledOffsetsFixed | 0x01800000
};

enum SVE64BitScatterStore_ScalarPlusUnpacked32BitUnscaledOffsetsOp {
  SVE64BitScatterStore_ScalarPlusUnpacked32BitUnscaledOffsetsFixed = 0xE4008000,
  SVE64BitScatterStore_ScalarPlusUnpacked32BitUnscaledOffsetsFMask = 0xFE60A000,
  SVE64BitScatterStore_ScalarPlusUnpacked32BitUnscaledOffsetsMask = 0xFFE0A000,
  ST1B_z_p_bz_d_x32_unscaled = SVE64BitScatterStore_ScalarPlusUnpacked32BitUnscaledOffsetsFixed,
  ST1H_z_p_bz_d_x32_unscaled = SVE64BitScatterStore_ScalarPlusUnpacked32BitUnscaledOffsetsFixed | 0x00800000,
  ST1W_z_p_bz_d_x32_unscaled = SVE64BitScatterStore_ScalarPlusUnpacked32BitUnscaledOffsetsFixed | 0x01000000,
  ST1D_z_p_bz_d_x32_unscaled = SVE64BitScatterStore_ScalarPlusUnpacked32BitUnscaledOffsetsFixed | 0x01800000
};

enum SVE64BitScatterStore_VectorPlusImmOp {
  SVE64BitScatterStore_VectorPlusImmFixed = 0xE440A000,
  SVE64BitScatterStore_VectorPlusImmFMask = 0xFE60E000,
  SVE64BitScatterStore_VectorPlusImmMask = 0xFFE0E000,
  ST1B_z_p_ai_d = SVE64BitScatterStore_VectorPlusImmFixed,
  ST1H_z_p_ai_d = SVE64BitScatterStore_VectorPlusImmFixed | 0x00800000,
  ST1W_z_p_ai_d = SVE64BitScatterStore_VectorPlusImmFixed | 0x01000000,
  ST1D_z_p_ai_d = SVE64BitScatterStore_VectorPlusImmFixed | 0x01800000
};

enum SVEAddressGenerationOp {
  SVEAddressGenerationFixed = 0x0420A000,
  SVEAddressGenerationFMask = 0xFF20F000,
  SVEAddressGenerationMask = 0xFFE0F000,
  ADR_z_az_d_s32_scaled = SVEAddressGenerationFixed,
  ADR_z_az_d_u32_scaled = SVEAddressGenerationFixed | 0x00400000,
  ADR_z_az_s_same_scaled = SVEAddressGenerationFixed | 0x00800000,
  ADR_z_az_d_same_scaled = SVEAddressGenerationFixed | 0x00C00000
};

enum SVEBitwiseLogicalUnpredicatedOp {
  SVEBitwiseLogicalUnpredicatedFixed = 0x04202000,
  SVEBitwiseLogicalUnpredicatedFMask = 0xFF20E000,
  SVEBitwiseLogicalUnpredicatedMask = 0xFFE0FC00,
  AND_z_zz = SVEBitwiseLogicalUnpredicatedFixed | 0x00001000,
  ORR_z_zz = SVEBitwiseLogicalUnpredicatedFixed | 0x00401000,
  EOR_z_zz = SVEBitwiseLogicalUnpredicatedFixed | 0x00801000,
  BIC_z_zz = SVEBitwiseLogicalUnpredicatedFixed | 0x00C01000
};

enum SVEBitwiseLogicalWithImm_UnpredicatedOp {
  SVEBitwiseLogicalWithImm_UnpredicatedFixed = 0x05000000,
  SVEBitwiseLogicalWithImm_UnpredicatedFMask = 0xFF3C0000,
  SVEBitwiseLogicalWithImm_UnpredicatedMask = 0xFFFC0000,
  ORR_z_zi = SVEBitwiseLogicalWithImm_UnpredicatedFixed,
  EOR_z_zi = SVEBitwiseLogicalWithImm_UnpredicatedFixed | 0x00400000,
  AND_z_zi = SVEBitwiseLogicalWithImm_UnpredicatedFixed | 0x00800000
};

enum SVEBitwiseLogical_PredicatedOp {
  SVEBitwiseLogical_PredicatedFixed = 0x04180000,
  SVEBitwiseLogical_PredicatedFMask = 0xFF38E000,
  SVEBitwiseLogical_PredicatedMask = 0xFF3FE000,
  ORR_z_p_zz = SVEBitwiseLogical_PredicatedFixed,
  EOR_z_p_zz = SVEBitwiseLogical_PredicatedFixed | 0x00010000,
  AND_z_p_zz = SVEBitwiseLogical_PredicatedFixed | 0x00020000,
  BIC_z_p_zz = SVEBitwiseLogical_PredicatedFixed | 0x00030000
};

enum SVEBitwiseShiftByImm_PredicatedOp {
  SVEBitwiseShiftByImm_PredicatedFixed = 0x04008000,
  SVEBitwiseShiftByImm_PredicatedFMask = 0xFF30E000,
  SVEBitwiseShiftByImm_PredicatedMask = 0xFF3FE000,
  ASR_z_p_zi = SVEBitwiseShiftByImm_PredicatedFixed,
  LSR_z_p_zi = SVEBitwiseShiftByImm_PredicatedFixed | 0x00010000,
  LSL_z_p_zi = SVEBitwiseShiftByImm_PredicatedFixed | 0x00030000,
  ASRD_z_p_zi = SVEBitwiseShiftByImm_PredicatedFixed | 0x00040000
};

enum SVEBitwiseShiftByVector_PredicatedOp {
  SVEBitwiseShiftByVector_PredicatedFixed = 0x04108000,
  SVEBitwiseShiftByVector_PredicatedFMask = 0xFF38E000,
  SVEBitwiseShiftByVector_PredicatedMask = 0xFF3FE000,
  ASR_z_p_zz = SVEBitwiseShiftByVector_PredicatedFixed,
  LSR_z_p_zz = SVEBitwiseShiftByVector_PredicatedFixed | 0x00010000,
  LSL_z_p_zz = SVEBitwiseShiftByVector_PredicatedFixed | 0x00030000,
  ASRR_z_p_zz = SVEBitwiseShiftByVector_PredicatedFixed | 0x00040000,
  LSRR_z_p_zz = SVEBitwiseShiftByVector_PredicatedFixed | 0x00050000,
  LSLR_z_p_zz = SVEBitwiseShiftByVector_PredicatedFixed | 0x00070000
};

enum SVEBitwiseShiftByWideElements_PredicatedOp {
  SVEBitwiseShiftByWideElements_PredicatedFixed = 0x04188000,
  SVEBitwiseShiftByWideElements_PredicatedFMask = 0xFF38E000,
  SVEBitwiseShiftByWideElements_PredicatedMask = 0xFF3FE000,
  ASR_z_p_zw = SVEBitwiseShiftByWideElements_PredicatedFixed,
  LSR_z_p_zw = SVEBitwiseShiftByWideElements_PredicatedFixed | 0x00010000,
  LSL_z_p_zw = SVEBitwiseShiftByWideElements_PredicatedFixed | 0x00030000
};

enum SVEBitwiseShiftUnpredicatedOp {
  SVEBitwiseShiftUnpredicatedFixed = 0x04208000,
  SVEBitwiseShiftUnpredicatedFMask = 0xFF20E000,
  SVEBitwiseShiftUnpredicatedMask = 0xFF20FC00,
  ASR_z_zw = SVEBitwiseShiftUnpredicatedFixed,
  LSR_z_zw = SVEBitwiseShiftUnpredicatedFixed | 0x00000400,
  LSL_z_zw = SVEBitwiseShiftUnpredicatedFixed | 0x00000C00,
  ASR_z_zi = SVEBitwiseShiftUnpredicatedFixed | 0x00001000,
  LSR_z_zi = SVEBitwiseShiftUnpredicatedFixed | 0x00001400,
  LSL_z_zi = SVEBitwiseShiftUnpredicatedFixed | 0x00001C00
};

enum SVEBroadcastBitmaskImmOp {
  SVEBroadcastBitmaskImmFixed = 0x05C00000,
  SVEBroadcastBitmaskImmFMask = 0xFFFC0000,
  SVEBroadcastBitmaskImmMask = 0xFFFC0000,
  DUPM_z_i = SVEBroadcastBitmaskImmFixed
};

enum SVEBroadcastFPImm_UnpredicatedOp {
  SVEBroadcastFPImm_UnpredicatedFixed = 0x2539C000,
  SVEBroadcastFPImm_UnpredicatedFMask = 0xFF39C000,
  SVEBroadcastFPImm_UnpredicatedMask = 0xFF3FE000,
  FDUP_z_i = SVEBroadcastFPImm_UnpredicatedFixed
};

enum SVEBroadcastGeneralRegisterOp {
  SVEBroadcastGeneralRegisterFixed = 0x05203800,
  SVEBroadcastGeneralRegisterFMask = 0xFF3FFC00,
  SVEBroadcastGeneralRegisterMask = 0xFF3FFC00,
  DUP_z_r = SVEBroadcastGeneralRegisterFixed
};

enum SVEBroadcastIndexElementOp {
  SVEBroadcastIndexElementFixed = 0x05202000,
  SVEBroadcastIndexElementFMask = 0xFF20FC00,
  SVEBroadcastIndexElementMask = 0xFF20FC00,
  DUP_z_zi = SVEBroadcastIndexElementFixed
};

enum SVEBroadcastIntImm_UnpredicatedOp {
  SVEBroadcastIntImm_UnpredicatedFixed = 0x2538C000,
  SVEBroadcastIntImm_UnpredicatedFMask = 0xFF39C000,
  SVEBroadcastIntImm_UnpredicatedMask = 0xFF3FC000,
  DUP_z_i = SVEBroadcastIntImm_UnpredicatedFixed
};

enum SVECompressActiveElementsOp {
  SVECompressActiveElementsFixed = 0x05A18000,
  SVECompressActiveElementsFMask = 0xFFBFE000,
  SVECompressActiveElementsMask = 0xFFBFE000,
  COMPACT_z_p_z = SVECompressActiveElementsFixed
};

enum SVEConditionallyBroadcastElementToVectorOp {
  SVEConditionallyBroadcastElementToVectorFixed = 0x05288000,
  SVEConditionallyBroadcastElementToVectorFMask = 0xFF3EE000,
  SVEConditionallyBroadcastElementToVectorMask = 0xFF3FE000,
  CLASTA_z_p_zz = SVEConditionallyBroadcastElementToVectorFixed,
  CLASTB_z_p_zz = SVEConditionallyBroadcastElementToVectorFixed | 0x00010000
};

enum SVEConditionallyExtractElementToGeneralRegisterOp {
  SVEConditionallyExtractElementToGeneralRegisterFixed = 0x0530A000,
  SVEConditionallyExtractElementToGeneralRegisterFMask = 0xFF3EE000,
  SVEConditionallyExtractElementToGeneralRegisterMask = 0xFF3FE000,
  CLASTA_r_p_z = SVEConditionallyExtractElementToGeneralRegisterFixed,
  CLASTB_r_p_z = SVEConditionallyExtractElementToGeneralRegisterFixed | 0x00010000
};

enum SVEConditionallyExtractElementToSIMDFPScalarOp {
  SVEConditionallyExtractElementToSIMDFPScalarFixed = 0x052A8000,
  SVEConditionallyExtractElementToSIMDFPScalarFMask = 0xFF3EE000,
  SVEConditionallyExtractElementToSIMDFPScalarMask = 0xFF3FE000,
  CLASTA_v_p_z = SVEConditionallyExtractElementToSIMDFPScalarFixed,
  CLASTB_v_p_z = SVEConditionallyExtractElementToSIMDFPScalarFixed | 0x00010000
};

enum SVEConditionallyTerminateScalarsOp {
  SVEConditionallyTerminateScalarsFixed = 0x25202000,
  SVEConditionallyTerminateScalarsFMask = 0xFF20FC0F,
  SVEConditionallyTerminateScalarsMask = 0xFFA0FC1F,
  CTERMEQ_rr = SVEConditionallyTerminateScalarsFixed | 0x00800000,
  CTERMNE_rr = SVEConditionallyTerminateScalarsFixed | 0x00800010
};

enum SVEConstructivePrefix_UnpredicatedOp {
  SVEConstructivePrefix_UnpredicatedFixed = 0x0420BC00,
  SVEConstructivePrefix_UnpredicatedFMask = 0xFF20FC00,
  SVEConstructivePrefix_UnpredicatedMask = 0xFFFFFC00,
  MOVPRFX_z_z = SVEConstructivePrefix_UnpredicatedFixed
};

enum SVEContiguousFirstFaultLoad_ScalarPlusScalarOp {
  SVEContiguousFirstFaultLoad_ScalarPlusScalarFixed = 0xA4006000,
  SVEContiguousFirstFaultLoad_ScalarPlusScalarFMask = 0xFE00E000,
  SVEContiguousFirstFaultLoad_ScalarPlusScalarMask = 0xFFE0E000,
  LDFF1B_z_p_br_u8 = SVEContiguousFirstFaultLoad_ScalarPlusScalarFixed,
  LDFF1B_z_p_br_u16 = SVEContiguousFirstFaultLoad_ScalarPlusScalarFixed | 0x00200000,
  LDFF1B_z_p_br_u32 = SVEContiguousFirstFaultLoad_ScalarPlusScalarFixed | 0x00400000,
  LDFF1B_z_p_br_u64 = SVEContiguousFirstFaultLoad_ScalarPlusScalarFixed | 0x00600000,
  LDFF1SW_z_p_br_s64 = SVEContiguousFirstFaultLoad_ScalarPlusScalarFixed | 0x00800000,
  LDFF1H_z_p_br_u16 = SVEContiguousFirstFaultLoad_ScalarPlusScalarFixed | 0x00A00000,
  LDFF1H_z_p_br_u32 = SVEContiguousFirstFaultLoad_ScalarPlusScalarFixed | 0x00C00000,
  LDFF1H_z_p_br_u64 = SVEContiguousFirstFaultLoad_ScalarPlusScalarFixed | 0x00E00000,
  LDFF1SH_z_p_br_s64 = SVEContiguousFirstFaultLoad_ScalarPlusScalarFixed | 0x01000000,
  LDFF1SH_z_p_br_s32 = SVEContiguousFirstFaultLoad_ScalarPlusScalarFixed | 0x01200000,
  LDFF1W_z_p_br_u32 = SVEContiguousFirstFaultLoad_ScalarPlusScalarFixed | 0x01400000,
  LDFF1W_z_p_br_u64 = SVEContiguousFirstFaultLoad_ScalarPlusScalarFixed | 0x01600000,
  LDFF1SB_z_p_br_s64 = SVEContiguousFirstFaultLoad_ScalarPlusScalarFixed | 0x01800000,
  LDFF1SB_z_p_br_s32 = SVEContiguousFirstFaultLoad_ScalarPlusScalarFixed | 0x01A00000,
  LDFF1SB_z_p_br_s16 = SVEContiguousFirstFaultLoad_ScalarPlusScalarFixed | 0x01C00000,
  LDFF1D_z_p_br_u64 = SVEContiguousFirstFaultLoad_ScalarPlusScalarFixed | 0x01E00000
};

enum SVEContiguousLoad_ScalarPlusImmOp {
  SVEContiguousLoad_ScalarPlusImmFixed = 0xA400A000,
  SVEContiguousLoad_ScalarPlusImmFMask = 0xFE10E000,
  SVEContiguousLoad_ScalarPlusImmMask = 0xFFF0E000,
  LD1B_z_p_bi_u8 = SVEContiguousLoad_ScalarPlusImmFixed,
  LD1B_z_p_bi_u16 = SVEContiguousLoad_ScalarPlusImmFixed | 0x00200000,
  LD1B_z_p_bi_u32 = SVEContiguousLoad_ScalarPlusImmFixed | 0x00400000,
  LD1B_z_p_bi_u64 = SVEContiguousLoad_ScalarPlusImmFixed | 0x00600000,
  LD1SW_z_p_bi_s64 = SVEContiguousLoad_ScalarPlusImmFixed | 0x00800000,
  LD1H_z_p_bi_u16 = SVEContiguousLoad_ScalarPlusImmFixed | 0x00A00000,
  LD1H_z_p_bi_u32 = SVEContiguousLoad_ScalarPlusImmFixed | 0x00C00000,
  LD1H_z_p_bi_u64 = SVEContiguousLoad_ScalarPlusImmFixed | 0x00E00000,
  LD1SH_z_p_bi_s64 = SVEContiguousLoad_ScalarPlusImmFixed | 0x01000000,
  LD1SH_z_p_bi_s32 = SVEContiguousLoad_ScalarPlusImmFixed | 0x01200000,
  LD1W_z_p_bi_u32 = SVEContiguousLoad_ScalarPlusImmFixed | 0x01400000,
  LD1W_z_p_bi_u64 = SVEContiguousLoad_ScalarPlusImmFixed | 0x01600000,
  LD1SB_z_p_bi_s64 = SVEContiguousLoad_ScalarPlusImmFixed | 0x01800000,
  LD1SB_z_p_bi_s32 = SVEContiguousLoad_ScalarPlusImmFixed | 0x01A00000,
  LD1SB_z_p_bi_s16 = SVEContiguousLoad_ScalarPlusImmFixed | 0x01C00000,
  LD1D_z_p_bi_u64 = SVEContiguousLoad_ScalarPlusImmFixed | 0x01E00000
};

enum SVEContiguousLoad_ScalarPlusScalarOp {
  SVEContiguousLoad_ScalarPlusScalarFixed = 0xA4004000,
  SVEContiguousLoad_ScalarPlusScalarFMask = 0xFE00E000,
  SVEContiguousLoad_ScalarPlusScalarMask = 0xFFE0E000,
  LD1B_z_p_br_u8 = SVEContiguousLoad_ScalarPlusScalarFixed,
  LD1B_z_p_br_u16 = SVEContiguousLoad_ScalarPlusScalarFixed | 0x00200000,
  LD1B_z_p_br_u32 = SVEContiguousLoad_ScalarPlusScalarFixed | 0x00400000,
  LD1B_z_p_br_u64 = SVEContiguousLoad_ScalarPlusScalarFixed | 0x00600000,
  LD1SW_z_p_br_s64 = SVEContiguousLoad_ScalarPlusScalarFixed | 0x00800000,
  LD1H_z_p_br_u16 = SVEContiguousLoad_ScalarPlusScalarFixed | 0x00A00000,
  LD1H_z_p_br_u32 = SVEContiguousLoad_ScalarPlusScalarFixed | 0x00C00000,
  LD1H_z_p_br_u64 = SVEContiguousLoad_ScalarPlusScalarFixed | 0x00E00000,
  LD1SH_z_p_br_s64 = SVEContiguousLoad_ScalarPlusScalarFixed | 0x01000000,
  LD1SH_z_p_br_s32 = SVEContiguousLoad_ScalarPlusScalarFixed | 0x01200000,
  LD1W_z_p_br_u32 = SVEContiguousLoad_ScalarPlusScalarFixed | 0x01400000,
  LD1W_z_p_br_u64 = SVEContiguousLoad_ScalarPlusScalarFixed | 0x01600000,
  LD1SB_z_p_br_s64 = SVEContiguousLoad_ScalarPlusScalarFixed | 0x01800000,
  LD1SB_z_p_br_s32 = SVEContiguousLoad_ScalarPlusScalarFixed | 0x01A00000,
  LD1SB_z_p_br_s16 = SVEContiguousLoad_ScalarPlusScalarFixed | 0x01C00000,
  LD1D_z_p_br_u64 = SVEContiguousLoad_ScalarPlusScalarFixed | 0x01E00000
};

enum SVEContiguousNonFaultLoad_ScalarPlusImmOp {
  SVEContiguousNonFaultLoad_ScalarPlusImmFixed = 0xA410A000,
  SVEContiguousNonFaultLoad_ScalarPlusImmFMask = 0xFE10E000,
  SVEContiguousNonFaultLoad_ScalarPlusImmMask = 0xFFF0E000,
  LDNF1B_z_p_bi_u8 = SVEContiguousNonFaultLoad_ScalarPlusImmFixed,
  LDNF1B_z_p_bi_u16 = SVEContiguousNonFaultLoad_ScalarPlusImmFixed | 0x00200000,
  LDNF1B_z_p_bi_u32 = SVEContiguousNonFaultLoad_ScalarPlusImmFixed | 0x00400000,
  LDNF1B_z_p_bi_u64 = SVEContiguousNonFaultLoad_ScalarPlusImmFixed | 0x00600000,
  LDNF1SW_z_p_bi_s64 = SVEContiguousNonFaultLoad_ScalarPlusImmFixed | 0x00800000,
  LDNF1H_z_p_bi_u16 = SVEContiguousNonFaultLoad_ScalarPlusImmFixed | 0x00A00000,
  LDNF1H_z_p_bi_u32 = SVEContiguousNonFaultLoad_ScalarPlusImmFixed | 0x00C00000,
  LDNF1H_z_p_bi_u64 = SVEContiguousNonFaultLoad_ScalarPlusImmFixed | 0x00E00000,
  LDNF1SH_z_p_bi_s64 = SVEContiguousNonFaultLoad_ScalarPlusImmFixed | 0x01000000,
  LDNF1SH_z_p_bi_s32 = SVEContiguousNonFaultLoad_ScalarPlusImmFixed | 0x01200000,
  LDNF1W_z_p_bi_u32 = SVEContiguousNonFaultLoad_ScalarPlusImmFixed | 0x01400000,
  LDNF1W_z_p_bi_u64 = SVEContiguousNonFaultLoad_ScalarPlusImmFixed | 0x01600000,
  LDNF1SB_z_p_bi_s64 = SVEContiguousNonFaultLoad_ScalarPlusImmFixed | 0x01800000,
  LDNF1SB_z_p_bi_s32 = SVEContiguousNonFaultLoad_ScalarPlusImmFixed | 0x01A00000,
  LDNF1SB_z_p_bi_s16 = SVEContiguousNonFaultLoad_ScalarPlusImmFixed | 0x01C00000,
  LDNF1D_z_p_bi_u64 = SVEContiguousNonFaultLoad_ScalarPlusImmFixed | 0x01E00000
};

enum SVEContiguousNonTemporalLoad_ScalarPlusImmOp {
  SVEContiguousNonTemporalLoad_ScalarPlusImmFixed = 0xA400E000,
  SVEContiguousNonTemporalLoad_ScalarPlusImmFMask = 0xFE70E000,
  SVEContiguousNonTemporalLoad_ScalarPlusImmMask = 0xFFF0E000,
  LDNT1B_z_p_bi_contiguous = SVEContiguousNonTemporalLoad_ScalarPlusImmFixed,
  LDNT1H_z_p_bi_contiguous = SVEContiguousNonTemporalLoad_ScalarPlusImmFixed | 0x00800000,
  LDNT1W_z_p_bi_contiguous = SVEContiguousNonTemporalLoad_ScalarPlusImmFixed | 0x01000000,
  LDNT1D_z_p_bi_contiguous = SVEContiguousNonTemporalLoad_ScalarPlusImmFixed | 0x01800000
};

enum SVEContiguousNonTemporalLoad_ScalarPlusScalarOp {
  SVEContiguousNonTemporalLoad_ScalarPlusScalarFixed = 0xA400C000,
  SVEContiguousNonTemporalLoad_ScalarPlusScalarFMask = 0xFE60E000,
  SVEContiguousNonTemporalLoad_ScalarPlusScalarMask = 0xFFE0E000,
  LDNT1B_z_p_br_contiguous = SVEContiguousNonTemporalLoad_ScalarPlusScalarFixed,
  LDNT1H_z_p_br_contiguous = SVEContiguousNonTemporalLoad_ScalarPlusScalarFixed | 0x00800000,
  LDNT1W_z_p_br_contiguous = SVEContiguousNonTemporalLoad_ScalarPlusScalarFixed | 0x01000000,
  LDNT1D_z_p_br_contiguous = SVEContiguousNonTemporalLoad_ScalarPlusScalarFixed | 0x01800000
};

enum SVEContiguousNonTemporalStore_ScalarPlusImmOp {
  SVEContiguousNonTemporalStore_ScalarPlusImmFixed = 0xE410E000,
  SVEContiguousNonTemporalStore_ScalarPlusImmFMask = 0xFE70E000,
  SVEContiguousNonTemporalStore_ScalarPlusImmMask = 0xFFF0E000,
  STNT1B_z_p_bi_contiguous = SVEContiguousNonTemporalStore_ScalarPlusImmFixed,
  STNT1H_z_p_bi_contiguous = SVEContiguousNonTemporalStore_ScalarPlusImmFixed | 0x00800000,
  STNT1W_z_p_bi_contiguous = SVEContiguousNonTemporalStore_ScalarPlusImmFixed | 0x01000000,
  STNT1D_z_p_bi_contiguous = SVEContiguousNonTemporalStore_ScalarPlusImmFixed | 0x01800000
};

enum SVEContiguousNonTemporalStore_ScalarPlusScalarOp {
  SVEContiguousNonTemporalStore_ScalarPlusScalarFixed = 0xE4006000,
  SVEContiguousNonTemporalStore_ScalarPlusScalarFMask = 0xFE60E000,
  SVEContiguousNonTemporalStore_ScalarPlusScalarMask = 0xFFE0E000,
  STNT1B_z_p_br_contiguous = SVEContiguousNonTemporalStore_ScalarPlusScalarFixed,
  STNT1H_z_p_br_contiguous = SVEContiguousNonTemporalStore_ScalarPlusScalarFixed | 0x00800000,
  STNT1W_z_p_br_contiguous = SVEContiguousNonTemporalStore_ScalarPlusScalarFixed | 0x01000000,
  STNT1D_z_p_br_contiguous = SVEContiguousNonTemporalStore_ScalarPlusScalarFixed | 0x01800000
};

enum SVEContiguousPrefetch_ScalarPlusImmOp {
  SVEContiguousPrefetch_ScalarPlusImmFixed = 0x85C00000,
  SVEContiguousPrefetch_ScalarPlusImmFMask = 0xFFC08010,
  SVEContiguousPrefetch_ScalarPlusImmMask = 0xFFC0E010,
  PRFB_i_p_bi_s = SVEContiguousPrefetch_ScalarPlusImmFixed,
  PRFH_i_p_bi_s = SVEContiguousPrefetch_ScalarPlusImmFixed | 0x00002000,
  PRFW_i_p_bi_s = SVEContiguousPrefetch_ScalarPlusImmFixed | 0x00004000,
  PRFD_i_p_bi_s = SVEContiguousPrefetch_ScalarPlusImmFixed | 0x00006000
};

enum SVEContiguousPrefetch_ScalarPlusScalarOp {
  SVEContiguousPrefetch_ScalarPlusScalarFixed = 0x8400C000,
  SVEContiguousPrefetch_ScalarPlusScalarFMask = 0xFE60E010,
  SVEContiguousPrefetch_ScalarPlusScalarMask = 0xFFE0E010,
  PRFB_i_p_br_s = SVEContiguousPrefetch_ScalarPlusScalarFixed,
  PRFH_i_p_br_s = SVEContiguousPrefetch_ScalarPlusScalarFixed | 0x00800000,
  PRFW_i_p_br_s = SVEContiguousPrefetch_ScalarPlusScalarFixed | 0x01000000,
  PRFD_i_p_br_s = SVEContiguousPrefetch_ScalarPlusScalarFixed | 0x01800000
};

enum SVEContiguousStore_ScalarPlusImmOp {
  SVEContiguousStore_ScalarPlusImmFixed = 0xE400E000,
  SVEContiguousStore_ScalarPlusImmFMask = 0xFE10E000,
  SVEContiguousStore_ScalarPlusImmMask = 0xFF90E000,
  ST1B_z_p_bi = SVEContiguousStore_ScalarPlusImmFixed,
  ST1H_z_p_bi = SVEContiguousStore_ScalarPlusImmFixed | 0x00800000,
  ST1W_z_p_bi = SVEContiguousStore_ScalarPlusImmFixed | 0x01000000,
  ST1D_z_p_bi = SVEContiguousStore_ScalarPlusImmFixed | 0x01800000
};

enum SVEContiguousStore_ScalarPlusScalarOp {
  SVEContiguousStore_ScalarPlusScalarFixed = 0xE4004000,
  SVEContiguousStore_ScalarPlusScalarFMask = 0xFE00E000,
  SVEContiguousStore_ScalarPlusScalarMask = 0xFF80E000,
  ST1B_z_p_br = SVEContiguousStore_ScalarPlusScalarFixed,
  ST1H_z_p_br = SVEContiguousStore_ScalarPlusScalarFixed | 0x00800000,
  ST1W_z_p_br = SVEContiguousStore_ScalarPlusScalarFixed | 0x01000000,
  ST1D_z_p_br = SVEContiguousStore_ScalarPlusScalarFixed | 0x01800000
};

enum SVECopyFPImm_PredicatedOp {
  SVECopyFPImm_PredicatedFixed = 0x0510C000,
  SVECopyFPImm_PredicatedFMask = 0xFF30E000,
  SVECopyFPImm_PredicatedMask = 0xFF30E000,
  FCPY_z_p_i = SVECopyFPImm_PredicatedFixed
};

enum SVECopyGeneralRegisterToVector_PredicatedOp {
  SVECopyGeneralRegisterToVector_PredicatedFixed = 0x0528A000,
  SVECopyGeneralRegisterToVector_PredicatedFMask = 0xFF3FE000,
  SVECopyGeneralRegisterToVector_PredicatedMask = 0xFF3FE000,
  CPY_z_p_r = SVECopyGeneralRegisterToVector_PredicatedFixed
};

enum SVECopyIntImm_PredicatedOp {
  SVECopyIntImm_PredicatedFixed = 0x05100000,
  SVECopyIntImm_PredicatedFMask = 0xFF308000,
  SVECopyIntImm_PredicatedMask = 0xFF308000,
  CPY_z_p_i = SVECopyIntImm_PredicatedFixed
};

enum SVECopySIMDFPScalarRegisterToVector_PredicatedOp {
  SVECopySIMDFPScalarRegisterToVector_PredicatedFixed = 0x05208000,
  SVECopySIMDFPScalarRegisterToVector_PredicatedFMask = 0xFF3FE000,
  SVECopySIMDFPScalarRegisterToVector_PredicatedMask = 0xFF3FE000,
  CPY_z_p_v = SVECopySIMDFPScalarRegisterToVector_PredicatedFixed
};

enum SVEElementCountOp {
  SVEElementCountFixed = 0x0420E000,
  SVEElementCountFMask = 0xFF30F800,
  SVEElementCountMask = 0xFFF0FC00,
  CNTB_r_s = SVEElementCountFixed,
  CNTH_r_s = SVEElementCountFixed | 0x00400000,
  CNTW_r_s = SVEElementCountFixed | 0x00800000,
  CNTD_r_s = SVEElementCountFixed | 0x00C00000
};

enum SVEExtractElementToGeneralRegisterOp {
  SVEExtractElementToGeneralRegisterFixed = 0x0520A000,
  SVEExtractElementToGeneralRegisterFMask = 0xFF3EE000,
  SVEExtractElementToGeneralRegisterMask = 0xFF3FE000,
  LASTA_r_p_z = SVEExtractElementToGeneralRegisterFixed,
  LASTB_r_p_z = SVEExtractElementToGeneralRegisterFixed | 0x00010000
};

enum SVEExtractElementToSIMDFPScalarRegisterOp {
  SVEExtractElementToSIMDFPScalarRegisterFixed = 0x05228000,
  SVEExtractElementToSIMDFPScalarRegisterFMask = 0xFF3EE000,
  SVEExtractElementToSIMDFPScalarRegisterMask = 0xFF3FE000,
  LASTA_v_p_z = SVEExtractElementToSIMDFPScalarRegisterFixed,
  LASTB_v_p_z = SVEExtractElementToSIMDFPScalarRegisterFixed | 0x00010000
};

enum SVEFFRInitialiseOp {
  SVEFFRInitialiseFixed = 0x252C9000,
  SVEFFRInitialiseFMask = 0xFF3FFFFF,
  SVEFFRInitialiseMask = 0xFFFFFFFF,
  SETFFR_f = SVEFFRInitialiseFixed
};

enum SVEFFRWriteFromPredicateOp {
  SVEFFRWriteFromPredicateFixed = 0x25289000,
  SVEFFRWriteFromPredicateFMask = 0xFF3FFE1F,
  SVEFFRWriteFromPredicateMask = 0xFFFFFE1F,
  WRFFR_f_p = SVEFFRWriteFromPredicateFixed
};

enum SVEFPAccumulatingReductionOp {
  SVEFPAccumulatingReductionFixed = 0x65182000,
  SVEFPAccumulatingReductionFMask = 0xFF38E000,
  SVEFPAccumulatingReductionMask = 0xFF3FE000,
  FADDA_v_p_z = SVEFPAccumulatingReductionFixed
};

enum SVEFPArithmeticUnpredicatedOp {
  SVEFPArithmeticUnpredicatedFixed = 0x65000000,
  SVEFPArithmeticUnpredicatedFMask = 0xFF20E000,
  SVEFPArithmeticUnpredicatedMask = 0xFF20FC00,
  FADD_z_zz = SVEFPArithmeticUnpredicatedFixed,
  FSUB_z_zz = SVEFPArithmeticUnpredicatedFixed | 0x00000400,
  FMUL_z_zz = SVEFPArithmeticUnpredicatedFixed | 0x00000800,
  FTSMUL_z_zz = SVEFPArithmeticUnpredicatedFixed | 0x00000C00,
  FRECPS_z_zz = SVEFPArithmeticUnpredicatedFixed | 0x00001800,
  FRSQRTS_z_zz = SVEFPArithmeticUnpredicatedFixed | 0x00001C00
};

enum SVEFPArithmeticWithImm_PredicatedOp {
  SVEFPArithmeticWithImm_PredicatedFixed = 0x65188000,
  SVEFPArithmeticWithImm_PredicatedFMask = 0xFF38E3C0,
  SVEFPArithmeticWithImm_PredicatedMask = 0xFF3FE3C0,
  FADD_z_p_zs = SVEFPArithmeticWithImm_PredicatedFixed,
  FSUB_z_p_zs = SVEFPArithmeticWithImm_PredicatedFixed | 0x00010000,
  FMUL_z_p_zs = SVEFPArithmeticWithImm_PredicatedFixed | 0x00020000,
  FSUBR_z_p_zs = SVEFPArithmeticWithImm_PredicatedFixed | 0x00030000,
  FMAXNM_z_p_zs = SVEFPArithmeticWithImm_PredicatedFixed | 0x00040000,
  FMINNM_z_p_zs = SVEFPArithmeticWithImm_PredicatedFixed | 0x00050000,
  FMAX_z_p_zs = SVEFPArithmeticWithImm_PredicatedFixed | 0x00060000,
  FMIN_z_p_zs = SVEFPArithmeticWithImm_PredicatedFixed | 0x00070000
};

enum SVEFPArithmetic_PredicatedOp {
  SVEFPArithmetic_PredicatedFixed = 0x65008000,
  SVEFPArithmetic_PredicatedFMask = 0xFF30E000,
  SVEFPArithmetic_PredicatedMask = 0xFF3FE000,
  FADD_z_p_zz = SVEFPArithmetic_PredicatedFixed,
  FSUB_z_p_zz = SVEFPArithmetic_PredicatedFixed | 0x00010000,
  FMUL_z_p_zz = SVEFPArithmetic_PredicatedFixed | 0x00020000,
  FSUBR_z_p_zz = SVEFPArithmetic_PredicatedFixed | 0x00030000,
  FMAXNM_z_p_zz = SVEFPArithmetic_PredicatedFixed | 0x00040000,
  FMINNM_z_p_zz = SVEFPArithmetic_PredicatedFixed | 0x00050000,
  FMAX_z_p_zz = SVEFPArithmetic_PredicatedFixed | 0x00060000,
  FMIN_z_p_zz = SVEFPArithmetic_PredicatedFixed | 0x00070000,
  FABD_z_p_zz = SVEFPArithmetic_PredicatedFixed | 0x00080000,
  FSCALE_z_p_zz = SVEFPArithmetic_PredicatedFixed | 0x00090000,
  FMULX_z_p_zz = SVEFPArithmetic_PredicatedFixed | 0x000A0000,
  FDIVR_z_p_zz = SVEFPArithmetic_PredicatedFixed | 0x000C0000,
  FDIV_z_p_zz = SVEFPArithmetic_PredicatedFixed | 0x000D0000
};

enum SVEFPCompareVectorsOp {
  SVEFPCompareVectorsFixed = 0x65004000,
  SVEFPCompareVectorsFMask = 0xFF204000,
  SVEFPCompareVectorsMask = 0xFF20E010,
  FCMGE_p_p_zz = SVEFPCompareVectorsFixed,
  FCMGT_p_p_zz = SVEFPCompareVectorsFixed | 0x00000010,
  FCMEQ_p_p_zz = SVEFPCompareVectorsFixed | 0x00002000,
  FCMNE_p_p_zz = SVEFPCompareVectorsFixed | 0x00002010,
  FCMUO_p_p_zz = SVEFPCompareVectorsFixed | 0x00008000,
  FACGE_p_p_zz = SVEFPCompareVectorsFixed | 0x00008010,
  FACGT_p_p_zz = SVEFPCompareVectorsFixed | 0x0000A010
};

enum SVEFPCompareWithZeroOp {
  SVEFPCompareWithZeroFixed = 0x65102000,
  SVEFPCompareWithZeroFMask = 0xFF38E000,
  SVEFPCompareWithZeroMask = 0xFF3FE010,
  FCMGE_p_p_z0 = SVEFPCompareWithZeroFixed,
  FCMGT_p_p_z0 = SVEFPCompareWithZeroFixed | 0x00000010,
  FCMLT_p_p_z0 = SVEFPCompareWithZeroFixed | 0x00010000,
  FCMLE_p_p_z0 = SVEFPCompareWithZeroFixed | 0x00010010,
  FCMEQ_p_p_z0 = SVEFPCompareWithZeroFixed | 0x00020000,
  FCMNE_p_p_z0 = SVEFPCompareWithZeroFixed | 0x00030000
};

enum SVEFPComplexAdditionOp {
  SVEFPComplexAdditionFixed = 0x64008000,
  SVEFPComplexAdditionFMask = 0xFF3EE000,
  SVEFPComplexAdditionMask = 0xFF3EE000,
  FCADD_z_p_zz = SVEFPComplexAdditionFixed
};

enum SVEFPComplexMulAddOp {
  SVEFPComplexMulAddFixed = 0x64000000,
  SVEFPComplexMulAddFMask = 0xFF208000,
  SVEFPComplexMulAddMask = 0xFF208000,
  FCMLA_z_p_zzz = SVEFPComplexMulAddFixed
};

enum SVEFPComplexMulAddIndexOp {
  SVEFPComplexMulAddIndexFixed = 0x64201000,
  SVEFPComplexMulAddIndexFMask = 0xFF20F000,
  SVEFPComplexMulAddIndexMask = 0xFFE0F000,
  FCMLA_z_zzzi_h = SVEFPComplexMulAddIndexFixed | 0x00800000,
  FCMLA_z_zzzi_s = SVEFPComplexMulAddIndexFixed | 0x00C00000
};

enum SVEFPConvertPrecisionOp {
  SVEFPConvertPrecisionFixed = 0x6508A000,
  SVEFPConvertPrecisionFMask = 0xFF3CE000,
  SVEFPConvertPrecisionMask = 0xFFFFE000,
  FCVT_z_p_z_s2h = SVEFPConvertPrecisionFixed | 0x00800000,
  FCVT_z_p_z_h2s = SVEFPConvertPrecisionFixed | 0x00810000,
  FCVT_z_p_z_d2h = SVEFPConvertPrecisionFixed | 0x00C00000,
  FCVT_z_p_z_h2d = SVEFPConvertPrecisionFixed | 0x00C10000,
  FCVT_z_p_z_d2s = SVEFPConvertPrecisionFixed | 0x00C20000,
  FCVT_z_p_z_s2d = SVEFPConvertPrecisionFixed | 0x00C30000
};

enum SVEFPConvertToIntOp {
  SVEFPConvertToIntFixed = 0x6518A000,
  SVEFPConvertToIntFMask = 0xFF38E000,
  SVEFPConvertToIntMask = 0xFFFFE000,
  FCVTZS_z_p_z_fp162h = SVEFPConvertToIntFixed | 0x00420000,
  FCVTZU_z_p_z_fp162h = SVEFPConvertToIntFixed | 0x00430000,
  FCVTZS_z_p_z_fp162w = SVEFPConvertToIntFixed | 0x00440000,
  FCVTZU_z_p_z_fp162w = SVEFPConvertToIntFixed | 0x00450000,
  FCVTZS_z_p_z_fp162x = SVEFPConvertToIntFixed | 0x00460000,
  FCVTZU_z_p_z_fp162x = SVEFPConvertToIntFixed | 0x00470000,
  FCVTZS_z_p_z_s2w = SVEFPConvertToIntFixed | 0x00840000,
  FCVTZU_z_p_z_s2w = SVEFPConvertToIntFixed | 0x00850000,
  FCVTZS_z_p_z_d2w = SVEFPConvertToIntFixed | 0x00C00000,
  FCVTZU_z_p_z_d2w = SVEFPConvertToIntFixed | 0x00C10000,
  FCVTZS_z_p_z_s2x = SVEFPConvertToIntFixed | 0x00C40000,
  FCVTZU_z_p_z_s2x = SVEFPConvertToIntFixed | 0x00C50000,
  FCVTZS_z_p_z_d2x = SVEFPConvertToIntFixed | 0x00C60000,
  FCVTZU_z_p_z_d2x = SVEFPConvertToIntFixed | 0x00C70000
};

enum SVEFPExponentialAcceleratorOp {
  SVEFPExponentialAcceleratorFixed = 0x0420B800,
  SVEFPExponentialAcceleratorFMask = 0xFF20FC00,
  SVEFPExponentialAcceleratorMask = 0xFF3FFC00,
  FEXPA_z_z = SVEFPExponentialAcceleratorFixed
};

enum SVEFPFastReductionOp {
  SVEFPFastReductionFixed = 0x65002000,
  SVEFPFastReductionFMask = 0xFF38E000,
  SVEFPFastReductionMask = 0xFF3FE000,
  FADDV_v_p_z = SVEFPFastReductionFixed,
  FMAXNMV_v_p_z = SVEFPFastReductionFixed | 0x00040000,
  FMINNMV_v_p_z = SVEFPFastReductionFixed | 0x00050000,
  FMAXV_v_p_z = SVEFPFastReductionFixed | 0x00060000,
  FMINV_v_p_z = SVEFPFastReductionFixed | 0x00070000
};

enum SVEFPMulAddOp {
  SVEFPMulAddFixed = 0x65200000,
  SVEFPMulAddFMask = 0xFF200000,
  SVEFPMulAddMask = 0xFF20E000,
  FMLA_z_p_zzz = SVEFPMulAddFixed,
  FMLS_z_p_zzz = SVEFPMulAddFixed | 0x00002000,
  FNMLA_z_p_zzz = SVEFPMulAddFixed | 0x00004000,
  FNMLS_z_p_zzz = SVEFPMulAddFixed | 0x00006000,
  FMAD_z_p_zzz = SVEFPMulAddFixed | 0x00008000,
  FMSB_z_p_zzz = SVEFPMulAddFixed | 0x0000A000,
  FNMAD_z_p_zzz = SVEFPMulAddFixed | 0x0000C000,
  FNMSB_z_p_zzz = SVEFPMulAddFixed | 0x0000E000
};

enum SVEFPMulAddIndexOp {
  SVEFPMulAddIndexFixed = 0x64200000,
  SVEFPMulAddIndexFMask = 0xFF20F800,
  SVEFPMulAddIndexMask = 0xFFE0FC00,
  FMLA_z_zzzi_h = SVEFPMulAddIndexFixed,
  FMLA_z_zzzi_h_i3h = FMLA_z_zzzi_h | 0x00400000,
  FMLS_z_zzzi_h = SVEFPMulAddIndexFixed | 0x00000400,
  FMLS_z_zzzi_h_i3h = FMLS_z_zzzi_h | 0x00400000,
  FMLA_z_zzzi_s = SVEFPMulAddIndexFixed | 0x00800000,
  FMLS_z_zzzi_s = SVEFPMulAddIndexFixed | 0x00800400,
  FMLA_z_zzzi_d = SVEFPMulAddIndexFixed | 0x00C00000,
  FMLS_z_zzzi_d = SVEFPMulAddIndexFixed | 0x00C00400
};

enum SVEFPMulIndexOp {
  SVEFPMulIndexFixed = 0x64202000,
  SVEFPMulIndexFMask = 0xFF20FC00,
  SVEFPMulIndexMask = 0xFFE0FC00,
  FMUL_z_zzi_h = SVEFPMulIndexFixed,
  FMUL_z_zzi_h_i3h = FMUL_z_zzi_h | 0x00400000,
  FMUL_z_zzi_s = SVEFPMulIndexFixed | 0x00800000,
  FMUL_z_zzi_d = SVEFPMulIndexFixed | 0x00C00000
};

enum SVEFPRoundToIntegralValueOp {
  SVEFPRoundToIntegralValueFixed = 0x6500A000,
  SVEFPRoundToIntegralValueFMask = 0xFF38E000,
  SVEFPRoundToIntegralValueMask = 0xFF3FE000,
  FRINTN_z_p_z = SVEFPRoundToIntegralValueFixed,
  FRINTP_z_p_z = SVEFPRoundToIntegralValueFixed | 0x00010000,
  FRINTM_z_p_z = SVEFPRoundToIntegralValueFixed | 0x00020000,
  FRINTZ_z_p_z = SVEFPRoundToIntegralValueFixed | 0x00030000,
  FRINTA_z_p_z = SVEFPRoundToIntegralValueFixed | 0x00040000,
  FRINTX_z_p_z = SVEFPRoundToIntegralValueFixed | 0x00060000,
  FRINTI_z_p_z = SVEFPRoundToIntegralValueFixed | 0x00070000
};

enum SVEFPTrigMulAddCoefficientOp {
  SVEFPTrigMulAddCoefficientFixed = 0x65108000,
  SVEFPTrigMulAddCoefficientFMask = 0xFF38FC00,
  SVEFPTrigMulAddCoefficientMask = 0xFF38FC00,
  FTMAD_z_zzi = SVEFPTrigMulAddCoefficientFixed
};

enum SVEFPTrigSelectCoefficientOp {
  SVEFPTrigSelectCoefficientFixed = 0x0420B000,
  SVEFPTrigSelectCoefficientFMask = 0xFF20F800,
  SVEFPTrigSelectCoefficientMask = 0xFF20FC00,
  FTSSEL_z_zz = SVEFPTrigSelectCoefficientFixed
};

enum SVEFPUnaryOpOp {
  SVEFPUnaryOpFixed = 0x650CA000,
  SVEFPUnaryOpFMask = 0xFF3CE000,
  SVEFPUnaryOpMask = 0xFF3FE000,
  FRECPX_z_p_z = SVEFPUnaryOpFixed,
  FSQRT_z_p_z = SVEFPUnaryOpFixed | 0x00010000
};

enum SVEFPUnaryOpUnpredicatedOp {
  SVEFPUnaryOpUnpredicatedFixed = 0x65083000,
  SVEFPUnaryOpUnpredicatedFMask = 0xFF38F000,
  SVEFPUnaryOpUnpredicatedMask = 0xFF3FFC00,
  FRECPE_z_z = SVEFPUnaryOpUnpredicatedFixed | 0x00060000,
  FRSQRTE_z_z = SVEFPUnaryOpUnpredicatedFixed | 0x00070000
};

enum SVEIncDecByPredicateCountOp {
  SVEIncDecByPredicateCountFixed = 0x25288000,
  SVEIncDecByPredicateCountFMask = 0xFF38F000,
  SVEIncDecByPredicateCountMask = 0xFF3FFE00,
  SQINCP_z_p_z = SVEIncDecByPredicateCountFixed,
  SQINCP_r_p_r_sx = SVEIncDecByPredicateCountFixed | 0x00000800,
  SQINCP_r_p_r_x = SVEIncDecByPredicateCountFixed | 0x00000C00,
  UQINCP_z_p_z = SVEIncDecByPredicateCountFixed | 0x00010000,
  UQINCP_r_p_r_uw = SVEIncDecByPredicateCountFixed | 0x00010800,
  UQINCP_r_p_r_x = SVEIncDecByPredicateCountFixed | 0x00010C00,
  SQDECP_z_p_z = SVEIncDecByPredicateCountFixed | 0x00020000,
  SQDECP_r_p_r_sx = SVEIncDecByPredicateCountFixed | 0x00020800,
  SQDECP_r_p_r_x = SVEIncDecByPredicateCountFixed | 0x00020C00,
  UQDECP_z_p_z = SVEIncDecByPredicateCountFixed | 0x00030000,
  UQDECP_r_p_r_uw = SVEIncDecByPredicateCountFixed | 0x00030800,
  UQDECP_r_p_r_x = SVEIncDecByPredicateCountFixed | 0x00030C00,
  INCP_z_p_z = SVEIncDecByPredicateCountFixed | 0x00040000,
  INCP_r_p_r = SVEIncDecByPredicateCountFixed | 0x00040800,
  DECP_z_p_z = SVEIncDecByPredicateCountFixed | 0x00050000,
  DECP_r_p_r = SVEIncDecByPredicateCountFixed | 0x00050800
};

enum SVEIncDecRegisterByElementCountOp {
  SVEIncDecRegisterByElementCountFixed = 0x0430E000,
  SVEIncDecRegisterByElementCountFMask = 0xFF30F800,
  SVEIncDecRegisterByElementCountMask = 0xFFF0FC00,
  INCB_r_rs = SVEIncDecRegisterByElementCountFixed,
  DECB_r_rs = SVEIncDecRegisterByElementCountFixed | 0x00000400,
  INCH_r_rs = SVEIncDecRegisterByElementCountFixed | 0x00400000,
  DECH_r_rs = SVEIncDecRegisterByElementCountFixed | 0x00400400,
  INCW_r_rs = SVEIncDecRegisterByElementCountFixed | 0x00800000,
  DECW_r_rs = SVEIncDecRegisterByElementCountFixed | 0x00800400,
  INCD_r_rs = SVEIncDecRegisterByElementCountFixed | 0x00C00000,
  DECD_r_rs = SVEIncDecRegisterByElementCountFixed | 0x00C00400
};

enum SVEIncDecVectorByElementCountOp {
  SVEIncDecVectorByElementCountFixed = 0x0430C000,
  SVEIncDecVectorByElementCountFMask = 0xFF30F800,
  SVEIncDecVectorByElementCountMask = 0xFFF0FC00,
  INCH_z_zs = SVEIncDecVectorByElementCountFixed | 0x00400000,
  DECH_z_zs = SVEIncDecVectorByElementCountFixed | 0x00400400,
  INCW_z_zs = SVEIncDecVectorByElementCountFixed | 0x00800000,
  DECW_z_zs = SVEIncDecVectorByElementCountFixed | 0x00800400,
  INCD_z_zs = SVEIncDecVectorByElementCountFixed | 0x00C00000,
  DECD_z_zs = SVEIncDecVectorByElementCountFixed | 0x00C00400
};

enum SVEIndexGenerationOp {
  SVEIndexGenerationFixed = 0x04204000,
  SVEIndexGenerationFMask = 0xFF20F000,
  SVEIndexGenerationMask = 0xFF20FC00,
  INDEX_z_ii = SVEIndexGenerationFixed,
  INDEX_z_ri = SVEIndexGenerationFixed | 0x00000400,
  INDEX_z_ir = SVEIndexGenerationFixed | 0x00000800,
  INDEX_z_rr = SVEIndexGenerationFixed | 0x00000C00
};

enum SVEInsertGeneralRegisterOp {
  SVEInsertGeneralRegisterFixed = 0x05243800,
  SVEInsertGeneralRegisterFMask = 0xFF3FFC00,
  SVEInsertGeneralRegisterMask = 0xFF3FFC00,
  INSR_z_r = SVEInsertGeneralRegisterFixed
};

enum SVEInsertSIMDFPScalarRegisterOp {
  SVEInsertSIMDFPScalarRegisterFixed = 0x05343800,
  SVEInsertSIMDFPScalarRegisterFMask = 0xFF3FFC00,
  SVEInsertSIMDFPScalarRegisterMask = 0xFF3FFC00,
  INSR_z_v = SVEInsertSIMDFPScalarRegisterFixed
};

enum SVEIntAddSubtractImm_UnpredicatedOp {
  SVEIntAddSubtractImm_UnpredicatedFixed = 0x2520C000,
  SVEIntAddSubtractImm_UnpredicatedFMask = 0xFF38C000,
  SVEIntAddSubtractImm_UnpredicatedMask = 0xFF3FC000,
  ADD_z_zi = SVEIntAddSubtractImm_UnpredicatedFixed,
  SUB_z_zi = SVEIntAddSubtractImm_UnpredicatedFixed | 0x00010000,
  SUBR_z_zi = SVEIntAddSubtractImm_UnpredicatedFixed | 0x00030000,
  SQADD_z_zi = SVEIntAddSubtractImm_UnpredicatedFixed | 0x00040000,
  UQADD_z_zi = SVEIntAddSubtractImm_UnpredicatedFixed | 0x00050000,
  SQSUB_z_zi = SVEIntAddSubtractImm_UnpredicatedFixed | 0x00060000,
  UQSUB_z_zi = SVEIntAddSubtractImm_UnpredicatedFixed | 0x00070000
};

enum SVEIntAddSubtractVectors_PredicatedOp {
  SVEIntAddSubtractVectors_PredicatedFixed = 0x04000000,
  SVEIntAddSubtractVectors_PredicatedFMask = 0xFF38E000,
  SVEIntAddSubtractVectors_PredicatedMask = 0xFF3FE000,
  ADD_z_p_zz = SVEIntAddSubtractVectors_PredicatedFixed,
  SUB_z_p_zz = SVEIntAddSubtractVectors_PredicatedFixed | 0x00010000,
  SUBR_z_p_zz = SVEIntAddSubtractVectors_PredicatedFixed | 0x00030000
};

enum SVEIntArithmeticUnpredicatedOp {
  SVEIntArithmeticUnpredicatedFixed = 0x04200000,
  SVEIntArithmeticUnpredicatedFMask = 0xFF20E000,
  SVEIntArithmeticUnpredicatedMask = 0xFF20FC00,
  ADD_z_zz = SVEIntArithmeticUnpredicatedFixed,
  SUB_z_zz = SVEIntArithmeticUnpredicatedFixed | 0x00000400,
  SQADD_z_zz = SVEIntArithmeticUnpredicatedFixed | 0x00001000,
  UQADD_z_zz = SVEIntArithmeticUnpredicatedFixed | 0x00001400,
  SQSUB_z_zz = SVEIntArithmeticUnpredicatedFixed | 0x00001800,
  UQSUB_z_zz = SVEIntArithmeticUnpredicatedFixed | 0x00001C00
};

enum SVEIntCompareScalarCountAndLimitOp {
  SVEIntCompareScalarCountAndLimitFixed = 0x25200000,
  SVEIntCompareScalarCountAndLimitFMask = 0xFF20E000,
  SVEIntCompareScalarCountAndLimitMask = 0xFF20EC10,
  WHILELT_p_p_rr = SVEIntCompareScalarCountAndLimitFixed | 0x00000400,
  WHILELE_p_p_rr = SVEIntCompareScalarCountAndLimitFixed | 0x00000410,
  WHILELO_p_p_rr = SVEIntCompareScalarCountAndLimitFixed | 0x00000C00,
  WHILELS_p_p_rr = SVEIntCompareScalarCountAndLimitFixed | 0x00000C10
};

enum SVEIntCompareSignedImmOp {
  SVEIntCompareSignedImmFixed = 0x25000000,
  SVEIntCompareSignedImmFMask = 0xFF204000,
  SVEIntCompareSignedImmMask = 0xFF20E010,
  CMPGE_p_p_zi = SVEIntCompareSignedImmFixed,
  CMPGT_p_p_zi = SVEIntCompareSignedImmFixed | 0x00000010,
  CMPLT_p_p_zi = SVEIntCompareSignedImmFixed | 0x00002000,
  CMPLE_p_p_zi = SVEIntCompareSignedImmFixed | 0x00002010,
  CMPEQ_p_p_zi = SVEIntCompareSignedImmFixed | 0x00008000,
  CMPNE_p_p_zi = SVEIntCompareSignedImmFixed | 0x00008010
};

enum SVEIntCompareUnsignedImmOp {
  SVEIntCompareUnsignedImmFixed = 0x24200000,
  SVEIntCompareUnsignedImmFMask = 0xFF200000,
  SVEIntCompareUnsignedImmMask = 0xFF202010,
  CMPHS_p_p_zi = SVEIntCompareUnsignedImmFixed,
  CMPHI_p_p_zi = SVEIntCompareUnsignedImmFixed | 0x00000010,
  CMPLO_p_p_zi = SVEIntCompareUnsignedImmFixed | 0x00002000,
  CMPLS_p_p_zi = SVEIntCompareUnsignedImmFixed | 0x00002010
};

enum SVEIntCompareVectorsOp {
  SVEIntCompareVectorsFixed = 0x24000000,
  SVEIntCompareVectorsFMask = 0xFF200000,
  SVEIntCompareVectorsMask = 0xFF20E010,
  CMPHS_p_p_zz = SVEIntCompareVectorsFixed,
  CMPHI_p_p_zz = SVEIntCompareVectorsFixed | 0x00000010,
  CMPEQ_p_p_zw = SVEIntCompareVectorsFixed | 0x00002000,
  CMPNE_p_p_zw = SVEIntCompareVectorsFixed | 0x00002010,
  CMPGE_p_p_zw = SVEIntCompareVectorsFixed | 0x00004000,
  CMPGT_p_p_zw = SVEIntCompareVectorsFixed | 0x00004010,
  CMPLT_p_p_zw = SVEIntCompareVectorsFixed | 0x00006000,
  CMPLE_p_p_zw = SVEIntCompareVectorsFixed | 0x00006010,
  CMPGE_p_p_zz = SVEIntCompareVectorsFixed | 0x00008000,
  CMPGT_p_p_zz = SVEIntCompareVectorsFixed | 0x00008010,
  CMPEQ_p_p_zz = SVEIntCompareVectorsFixed | 0x0000A000,
  CMPNE_p_p_zz = SVEIntCompareVectorsFixed | 0x0000A010,
  CMPHS_p_p_zw = SVEIntCompareVectorsFixed | 0x0000C000,
  CMPHI_p_p_zw = SVEIntCompareVectorsFixed | 0x0000C010,
  CMPLO_p_p_zw = SVEIntCompareVectorsFixed | 0x0000E000,
  CMPLS_p_p_zw = SVEIntCompareVectorsFixed | 0x0000E010
};

enum SVEIntConvertToFPOp {
  SVEIntConvertToFPFixed = 0x6510A000,
  SVEIntConvertToFPFMask = 0xFF38E000,
  SVEIntConvertToFPMask = 0xFFFFE000,
  SCVTF_z_p_z_h2fp16 = SVEIntConvertToFPFixed | 0x00420000,
  UCVTF_z_p_z_h2fp16 = SVEIntConvertToFPFixed | 0x00430000,
  SCVTF_z_p_z_w2fp16 = SVEIntConvertToFPFixed | 0x00440000,
  UCVTF_z_p_z_w2fp16 = SVEIntConvertToFPFixed | 0x00450000,
  SCVTF_z_p_z_x2fp16 = SVEIntConvertToFPFixed | 0x00460000,
  UCVTF_z_p_z_x2fp16 = SVEIntConvertToFPFixed | 0x00470000,
  SCVTF_z_p_z_w2s = SVEIntConvertToFPFixed | 0x00840000,
  UCVTF_z_p_z_w2s = SVEIntConvertToFPFixed | 0x00850000,
  SCVTF_z_p_z_w2d = SVEIntConvertToFPFixed | 0x00C00000,
  UCVTF_z_p_z_w2d = SVEIntConvertToFPFixed | 0x00C10000,
  SCVTF_z_p_z_x2s = SVEIntConvertToFPFixed | 0x00C40000,
  UCVTF_z_p_z_x2s = SVEIntConvertToFPFixed | 0x00C50000,
  SCVTF_z_p_z_x2d = SVEIntConvertToFPFixed | 0x00C60000,
  UCVTF_z_p_z_x2d = SVEIntConvertToFPFixed | 0x00C70000
};

enum SVEIntDivideVectors_PredicatedOp {
  SVEIntDivideVectors_PredicatedFixed = 0x04140000,
  SVEIntDivideVectors_PredicatedFMask = 0xFF3CE000,
  SVEIntDivideVectors_PredicatedMask = 0xFF3FE000,
  SDIV_z_p_zz = SVEIntDivideVectors_PredicatedFixed,
  UDIV_z_p_zz = SVEIntDivideVectors_PredicatedFixed | 0x00010000,
  SDIVR_z_p_zz = SVEIntDivideVectors_PredicatedFixed | 0x00020000,
  UDIVR_z_p_zz = SVEIntDivideVectors_PredicatedFixed | 0x00030000
};

enum SVEIntMinMaxDifference_PredicatedOp {
  SVEIntMinMaxDifference_PredicatedFixed = 0x04080000,
  SVEIntMinMaxDifference_PredicatedFMask = 0xFF38E000,
  SVEIntMinMaxDifference_PredicatedMask = 0xFF3FE000,
  SMAX_z_p_zz = SVEIntMinMaxDifference_PredicatedFixed,
  UMAX_z_p_zz = SVEIntMinMaxDifference_PredicatedFixed | 0x00010000,
  SMIN_z_p_zz = SVEIntMinMaxDifference_PredicatedFixed | 0x00020000,
  UMIN_z_p_zz = SVEIntMinMaxDifference_PredicatedFixed | 0x00030000,
  SABD_z_p_zz = SVEIntMinMaxDifference_PredicatedFixed | 0x00040000,
  UABD_z_p_zz = SVEIntMinMaxDifference_PredicatedFixed | 0x00050000
};

enum SVEIntMinMaxImm_UnpredicatedOp {
  SVEIntMinMaxImm_UnpredicatedFixed = 0x2528C000,
  SVEIntMinMaxImm_UnpredicatedFMask = 0xFF38C000,
  SVEIntMinMaxImm_UnpredicatedMask = 0xFF3FE000,
  SMAX_z_zi = SVEIntMinMaxImm_UnpredicatedFixed,
  UMAX_z_zi = SVEIntMinMaxImm_UnpredicatedFixed | 0x00010000,
  SMIN_z_zi = SVEIntMinMaxImm_UnpredicatedFixed | 0x00020000,
  UMIN_z_zi = SVEIntMinMaxImm_UnpredicatedFixed | 0x00030000
};

enum SVEIntMulAddPredicatedOp {
  SVEIntMulAddPredicatedFixed = 0x04004000,
  SVEIntMulAddPredicatedFMask = 0xFF204000,
  SVEIntMulAddPredicatedMask = 0xFF20E000,
  MLA_z_p_zzz = SVEIntMulAddPredicatedFixed,
  MLS_z_p_zzz = SVEIntMulAddPredicatedFixed | 0x00002000,
  MAD_z_p_zzz = SVEIntMulAddPredicatedFixed | 0x00008000,
  MSB_z_p_zzz = SVEIntMulAddPredicatedFixed | 0x0000A000
};

enum SVEIntMulAddUnpredicatedOp {
  SVEIntMulAddUnpredicatedFixed = 0x44000000,
  SVEIntMulAddUnpredicatedFMask = 0xFF208000,
  SVEIntMulAddUnpredicatedMask = 0xFF20FC00,
  SDOT_z_zzz = SVEIntMulAddUnpredicatedFixed,
  UDOT_z_zzz = SVEIntMulAddUnpredicatedFixed | 0x00000400
};

enum SVEIntMulImm_UnpredicatedOp {
  SVEIntMulImm_UnpredicatedFixed = 0x2530C000,
  SVEIntMulImm_UnpredicatedFMask = 0xFF38C000,
  SVEIntMulImm_UnpredicatedMask = 0xFF3FE000,
  MUL_z_zi = SVEIntMulImm_UnpredicatedFixed
};

enum SVEIntMulVectors_PredicatedOp {
  SVEIntMulVectors_PredicatedFixed = 0x04100000,
  SVEIntMulVectors_PredicatedFMask = 0xFF3CE000,
  SVEIntMulVectors_PredicatedMask = 0xFF3FE000,
  MUL_z_p_zz = SVEIntMulVectors_PredicatedFixed,
  SMULH_z_p_zz = SVEIntMulVectors_PredicatedFixed | 0x00020000,
  UMULH_z_p_zz = SVEIntMulVectors_PredicatedFixed | 0x00030000
};

enum SVEMovprfxOp {
  SVEMovprfxFixed = 0x04002000,
  SVEMovprfxFMask = 0xFF20E000,
  SVEMovprfxMask = 0xFF3EE000,
  MOVPRFX_z_p_z = SVEMovprfxFixed | 0x00100000
};

enum SVEIntReductionOp {
  SVEIntReductionFixed = 0x04002000,
  SVEIntReductionFMask = 0xFF20E000,
  SVEIntReductionMask = 0xFF3FE000,
  SADDV_r_p_z = SVEIntReductionFixed,
  UADDV_r_p_z = SVEIntReductionFixed | 0x00010000,
  SMAXV_r_p_z = SVEIntReductionFixed | 0x00080000,
  UMAXV_r_p_z = SVEIntReductionFixed | 0x00090000,
  SMINV_r_p_z = SVEIntReductionFixed | 0x000A0000,
  UMINV_r_p_z = SVEIntReductionFixed | 0x000B0000
};

enum SVEIntReductionLogicalOp {
  SVEIntReductionLogicalFixed = 0x04182000,
  SVEIntReductionLogicalFMask = 0xFF38E000,
  SVEIntReductionLogicalMask = 0xFF3FE000,
  ORV_r_p_z = SVEIntReductionLogicalFixed | 0x00180000,
  EORV_r_p_z = SVEIntReductionLogicalFixed | 0x00190000,
  ANDV_r_p_z = SVEIntReductionLogicalFixed | 0x001A0000
};

enum SVEIntUnaryArithmeticPredicatedOp {
  SVEIntUnaryArithmeticPredicatedFixed = 0x0400A000,
  SVEIntUnaryArithmeticPredicatedFMask = 0xFF20E000,
  SVEIntUnaryArithmeticPredicatedMask = 0xFF3FE000,
  SXTB_z_p_z = SVEIntUnaryArithmeticPredicatedFixed | 0x00100000,
  UXTB_z_p_z = SVEIntUnaryArithmeticPredicatedFixed | 0x00110000,
  SXTH_z_p_z = SVEIntUnaryArithmeticPredicatedFixed | 0x00120000,
  UXTH_z_p_z = SVEIntUnaryArithmeticPredicatedFixed | 0x00130000,
  SXTW_z_p_z = SVEIntUnaryArithmeticPredicatedFixed | 0x00140000,
  UXTW_z_p_z = SVEIntUnaryArithmeticPredicatedFixed | 0x00150000,
  ABS_z_p_z = SVEIntUnaryArithmeticPredicatedFixed | 0x00160000,
  NEG_z_p_z = SVEIntUnaryArithmeticPredicatedFixed | 0x00170000,
  CLS_z_p_z = SVEIntUnaryArithmeticPredicatedFixed | 0x00180000,
  CLZ_z_p_z = SVEIntUnaryArithmeticPredicatedFixed | 0x00190000,
  CNT_z_p_z = SVEIntUnaryArithmeticPredicatedFixed | 0x001A0000,
  CNOT_z_p_z = SVEIntUnaryArithmeticPredicatedFixed | 0x001B0000,
  FABS_z_p_z = SVEIntUnaryArithmeticPredicatedFixed | 0x001C0000,
  FNEG_z_p_z = SVEIntUnaryArithmeticPredicatedFixed | 0x001D0000,
  NOT_z_p_z = SVEIntUnaryArithmeticPredicatedFixed | 0x001E0000
};

enum SVELoadAndBroadcastElementOp {
  SVELoadAndBroadcastElementFixed = 0x84408000,
  SVELoadAndBroadcastElementFMask = 0xFE408000,
  SVELoadAndBroadcastElementMask = 0xFFC0E000,
  LD1RB_z_p_bi_u8 = SVELoadAndBroadcastElementFixed,
  LD1RB_z_p_bi_u16 = SVELoadAndBroadcastElementFixed | 0x00002000,
  LD1RB_z_p_bi_u32 = SVELoadAndBroadcastElementFixed | 0x00004000,
  LD1RB_z_p_bi_u64 = SVELoadAndBroadcastElementFixed | 0x00006000,
  LD1RSW_z_p_bi_s64 = SVELoadAndBroadcastElementFixed | 0x00800000,
  LD1RH_z_p_bi_u16 = SVELoadAndBroadcastElementFixed | 0x00802000,
  LD1RH_z_p_bi_u32 = SVELoadAndBroadcastElementFixed | 0x00804000,
  LD1RH_z_p_bi_u64 = SVELoadAndBroadcastElementFixed | 0x00806000,
  LD1RSH_z_p_bi_s64 = SVELoadAndBroadcastElementFixed | 0x01000000,
  LD1RSH_z_p_bi_s32 = SVELoadAndBroadcastElementFixed | 0x01002000,
  LD1RW_z_p_bi_u32 = SVELoadAndBroadcastElementFixed | 0x01004000,
  LD1RW_z_p_bi_u64 = SVELoadAndBroadcastElementFixed | 0x01006000,
  LD1RSB_z_p_bi_s64 = SVELoadAndBroadcastElementFixed | 0x01800000,
  LD1RSB_z_p_bi_s32 = SVELoadAndBroadcastElementFixed | 0x01802000,
  LD1RSB_z_p_bi_s16 = SVELoadAndBroadcastElementFixed | 0x01804000,
  LD1RD_z_p_bi_u64 = SVELoadAndBroadcastElementFixed | 0x01806000
};

enum SVELoadAndBroadcastQuadword_ScalarPlusImmOp {
  SVELoadAndBroadcastQuadword_ScalarPlusImmFixed = 0xA4002000,
  SVELoadAndBroadcastQuadword_ScalarPlusImmFMask = 0xFE10E000,
  SVELoadAndBroadcastQuadword_ScalarPlusImmMask = 0xFFF0E000,
  LD1RQB_z_p_bi_u8 = SVELoadAndBroadcastQuadword_ScalarPlusImmFixed,
  LD1RQH_z_p_bi_u16 = SVELoadAndBroadcastQuadword_ScalarPlusImmFixed | 0x00800000,
  LD1RQW_z_p_bi_u32 = SVELoadAndBroadcastQuadword_ScalarPlusImmFixed | 0x01000000,
  LD1RQD_z_p_bi_u64 = SVELoadAndBroadcastQuadword_ScalarPlusImmFixed | 0x01800000
};

enum SVELoadAndBroadcastQuadword_ScalarPlusScalarOp {
  SVELoadAndBroadcastQuadword_ScalarPlusScalarFixed = 0xA4000000,
  SVELoadAndBroadcastQuadword_ScalarPlusScalarFMask = 0xFE00E000,
  SVELoadAndBroadcastQuadword_ScalarPlusScalarMask = 0xFFE0E000,
  LD1RQB_z_p_br_contiguous = SVELoadAndBroadcastQuadword_ScalarPlusScalarFixed,
  LD1RQH_z_p_br_contiguous = SVELoadAndBroadcastQuadword_ScalarPlusScalarFixed | 0x00800000,
  LD1RQW_z_p_br_contiguous = SVELoadAndBroadcastQuadword_ScalarPlusScalarFixed | 0x01000000,
  LD1RQD_z_p_br_contiguous = SVELoadAndBroadcastQuadword_ScalarPlusScalarFixed | 0x01800000
};

enum SVELoadMultipleStructures_ScalarPlusImmOp {
  SVELoadMultipleStructures_ScalarPlusImmFixed = 0xA400E000,
  SVELoadMultipleStructures_ScalarPlusImmFMask = 0xFE10E000,
  SVELoadMultipleStructures_ScalarPlusImmMask = 0xFFF0E000,
  LD2B_z_p_bi_contiguous = SVELoadMultipleStructures_ScalarPlusImmFixed | 0x00200000,
  LD3B_z_p_bi_contiguous = SVELoadMultipleStructures_ScalarPlusImmFixed | 0x00400000,
  LD4B_z_p_bi_contiguous = SVELoadMultipleStructures_ScalarPlusImmFixed | 0x00600000,
  LD2H_z_p_bi_contiguous = SVELoadMultipleStructures_ScalarPlusImmFixed | 0x00A00000,
  LD3H_z_p_bi_contiguous = SVELoadMultipleStructures_ScalarPlusImmFixed | 0x00C00000,
  LD4H_z_p_bi_contiguous = SVELoadMultipleStructures_ScalarPlusImmFixed | 0x00E00000,
  LD2W_z_p_bi_contiguous = SVELoadMultipleStructures_ScalarPlusImmFixed | 0x01200000,
  LD3W_z_p_bi_contiguous = SVELoadMultipleStructures_ScalarPlusImmFixed | 0x01400000,
  LD4W_z_p_bi_contiguous = SVELoadMultipleStructures_ScalarPlusImmFixed | 0x01600000,
  LD2D_z_p_bi_contiguous = SVELoadMultipleStructures_ScalarPlusImmFixed | 0x01A00000,
  LD3D_z_p_bi_contiguous = SVELoadMultipleStructures_ScalarPlusImmFixed | 0x01C00000,
  LD4D_z_p_bi_contiguous = SVELoadMultipleStructures_ScalarPlusImmFixed | 0x01E00000
};

enum SVELoadMultipleStructures_ScalarPlusScalarOp {
  SVELoadMultipleStructures_ScalarPlusScalarFixed = 0xA400C000,
  SVELoadMultipleStructures_ScalarPlusScalarFMask = 0xFE00E000,
  SVELoadMultipleStructures_ScalarPlusScalarMask = 0xFFE0E000,
  LD2B_z_p_br_contiguous = SVELoadMultipleStructures_ScalarPlusScalarFixed | 0x00200000,
  LD3B_z_p_br_contiguous = SVELoadMultipleStructures_ScalarPlusScalarFixed | 0x00400000,
  LD4B_z_p_br_contiguous = SVELoadMultipleStructures_ScalarPlusScalarFixed | 0x00600000,
  LD2H_z_p_br_contiguous = SVELoadMultipleStructures_ScalarPlusScalarFixed | 0x00A00000,
  LD3H_z_p_br_contiguous = SVELoadMultipleStructures_ScalarPlusScalarFixed | 0x00C00000,
  LD4H_z_p_br_contiguous = SVELoadMultipleStructures_ScalarPlusScalarFixed | 0x00E00000,
  LD2W_z_p_br_contiguous = SVELoadMultipleStructures_ScalarPlusScalarFixed | 0x01200000,
  LD3W_z_p_br_contiguous = SVELoadMultipleStructures_ScalarPlusScalarFixed | 0x01400000,
  LD4W_z_p_br_contiguous = SVELoadMultipleStructures_ScalarPlusScalarFixed | 0x01600000,
  LD2D_z_p_br_contiguous = SVELoadMultipleStructures_ScalarPlusScalarFixed | 0x01A00000,
  LD3D_z_p_br_contiguous = SVELoadMultipleStructures_ScalarPlusScalarFixed | 0x01C00000,
  LD4D_z_p_br_contiguous = SVELoadMultipleStructures_ScalarPlusScalarFixed | 0x01E00000
};

enum SVELoadPredicateRegisterOp {
  SVELoadPredicateRegisterFixed = 0x85800000,
  SVELoadPredicateRegisterFMask = 0xFFC0E010,
  SVELoadPredicateRegisterMask = 0xFFC0E010,
  LDR_p_bi = SVELoadPredicateRegisterFixed
};

enum SVELoadVectorRegisterOp {
  SVELoadVectorRegisterFixed = 0x85804000,
  SVELoadVectorRegisterFMask = 0xFFC0E000,
  SVELoadVectorRegisterMask = 0xFFC0E000,
  LDR_z_bi = SVELoadVectorRegisterFixed
};

enum SVEMulIndexOp {
  SVEMulIndexFixed = 0x44200000,
  SVEMulIndexFMask = 0xFF200000,
  SVEMulIndexMask = 0xFFE0FC00,
  SDOT_z_zzzi_s = SVEMulIndexFixed | 0x00800000,
  UDOT_z_zzzi_s = SVEMulIndexFixed | 0x00800400,
  SDOT_z_zzzi_d = SVEMulIndexFixed | 0x00C00000,
  UDOT_z_zzzi_d = SVEMulIndexFixed | 0x00C00400
};

enum SVEPartitionBreakConditionOp {
  SVEPartitionBreakConditionFixed = 0x25104000,
  SVEPartitionBreakConditionFMask = 0xFF3FC200,
  SVEPartitionBreakConditionMask = 0xFFFFC200,
  BRKA_p_p_p = SVEPartitionBreakConditionFixed,
  BRKAS_p_p_p_z = SVEPartitionBreakConditionFixed | 0x00400000,
  BRKB_p_p_p = SVEPartitionBreakConditionFixed | 0x00800000,
  BRKBS_p_p_p_z = SVEPartitionBreakConditionFixed | 0x00C00000
};

enum SVEPermutePredicateElementsOp {
  SVEPermutePredicateElementsFixed = 0x05204000,
  SVEPermutePredicateElementsFMask = 0xFF30E210,
  SVEPermutePredicateElementsMask = 0xFF30FE10,
  ZIP1_p_pp = SVEPermutePredicateElementsFixed,
  ZIP2_p_pp = SVEPermutePredicateElementsFixed | 0x00000400,
  UZP1_p_pp = SVEPermutePredicateElementsFixed | 0x00000800,
  UZP2_p_pp = SVEPermutePredicateElementsFixed | 0x00000C00,
  TRN1_p_pp = SVEPermutePredicateElementsFixed | 0x00001000,
  TRN2_p_pp = SVEPermutePredicateElementsFixed | 0x00001400
};

enum SVEPermuteVectorExtractOp {
  SVEPermuteVectorExtractFixed = 0x05200000,
  SVEPermuteVectorExtractFMask = 0xFF20E000,
  SVEPermuteVectorExtractMask = 0xFFE0E000,
  EXT_z_zi_des = SVEPermuteVectorExtractFixed
};

enum SVEPermuteVectorInterleavingOp {
  SVEPermuteVectorInterleavingFixed = 0x05206000,
  SVEPermuteVectorInterleavingFMask = 0xFF20E000,
  SVEPermuteVectorInterleavingMask = 0xFF20FC00,
  ZIP1_z_zz = SVEPermuteVectorInterleavingFixed,
  ZIP2_z_zz = SVEPermuteVectorInterleavingFixed | 0x00000400,
  UZP1_z_zz = SVEPermuteVectorInterleavingFixed | 0x00000800,
  UZP2_z_zz = SVEPermuteVectorInterleavingFixed | 0x00000C00,
  TRN1_z_zz = SVEPermuteVectorInterleavingFixed | 0x00001000,
  TRN2_z_zz = SVEPermuteVectorInterleavingFixed | 0x00001400
};

enum SVEPredicateCountOp {
  SVEPredicateCountFixed = 0x25208000,
  SVEPredicateCountFMask = 0xFF38C000,
  SVEPredicateCountMask = 0xFF3FC200,
  CNTP_r_p_p = SVEPredicateCountFixed
};

enum SVEPredicateFirstActiveOp {
  SVEPredicateFirstActiveFixed = 0x2518C000,
  SVEPredicateFirstActiveFMask = 0xFF3FFE10,
  SVEPredicateFirstActiveMask = 0xFFFFFE10,
  PFIRST_p_p_p = SVEPredicateFirstActiveFixed | 0x00400000
};

enum SVEPredicateInitializeOp {
  SVEPredicateInitializeFixed = 0x2518E000,
  SVEPredicateInitializeFMask = 0xFF3EFC10,
  SVEPredicateInitializeMask = 0xFF3FFC10,
  SVEPredicateInitializeSetFlagsBit = 0x00010000,
  PTRUE_p_s = SVEPredicateInitializeFixed | 0x00000000,
  PTRUES_p_s = SVEPredicateInitializeFixed | SVEPredicateInitializeSetFlagsBit
};

enum SVEPredicateLogicalOp {
  SVEPredicateLogicalFixed = 0x25004000,
  SVEPredicateLogicalFMask = 0xFF30C000,
  SVEPredicateLogicalMask = 0xFFF0C210,
  SVEPredicateLogicalSetFlagsBit = 0x00400000,
  AND_p_p_pp_z = SVEPredicateLogicalFixed,
  ANDS_p_p_pp_z = AND_p_p_pp_z | SVEPredicateLogicalSetFlagsBit,
  BIC_p_p_pp_z = SVEPredicateLogicalFixed | 0x00000010,
  BICS_p_p_pp_z = BIC_p_p_pp_z | SVEPredicateLogicalSetFlagsBit,
  EOR_p_p_pp_z = SVEPredicateLogicalFixed | 0x00000200,
  EORS_p_p_pp_z = EOR_p_p_pp_z | SVEPredicateLogicalSetFlagsBit,
  ORR_p_p_pp_z = SVEPredicateLogicalFixed | 0x00800000,
  ORRS_p_p_pp_z = ORR_p_p_pp_z | SVEPredicateLogicalSetFlagsBit,
  ORN_p_p_pp_z = SVEPredicateLogicalFixed | 0x00800010,
  ORNS_p_p_pp_z = ORN_p_p_pp_z | SVEPredicateLogicalSetFlagsBit,
  NAND_p_p_pp_z = SVEPredicateLogicalFixed | 0x00800210,
  NANDS_p_p_pp_z = NAND_p_p_pp_z | SVEPredicateLogicalSetFlagsBit,
  NOR_p_p_pp_z = SVEPredicateLogicalFixed | 0x00800200,
  NORS_p_p_pp_z = NOR_p_p_pp_z | SVEPredicateLogicalSetFlagsBit,
  SEL_p_p_pp = SVEPredicateLogicalFixed | 0x00000210
};

enum SVEPredicateNextActiveOp {
  SVEPredicateNextActiveFixed = 0x2519C400,
  SVEPredicateNextActiveFMask = 0xFF3FFE10,
  SVEPredicateNextActiveMask = 0xFF3FFE10,
  PNEXT_p_p_p = SVEPredicateNextActiveFixed
};

enum SVEPredicateReadFromFFR_PredicatedOp {
  SVEPredicateReadFromFFR_PredicatedFixed = 0x2518F000,
  SVEPredicateReadFromFFR_PredicatedFMask = 0xFF3FFE10,
  SVEPredicateReadFromFFR_PredicatedMask = 0xFFFFFE10,
  RDFFR_p_p_f = SVEPredicateReadFromFFR_PredicatedFixed,
  RDFFRS_p_p_f = SVEPredicateReadFromFFR_PredicatedFixed | 0x00400000
};

enum SVEPredicateReadFromFFR_UnpredicatedOp {
  SVEPredicateReadFromFFR_UnpredicatedFixed = 0x2519F000,
  SVEPredicateReadFromFFR_UnpredicatedFMask = 0xFF3FFFF0,
  SVEPredicateReadFromFFR_UnpredicatedMask = 0xFFFFFFF0,
  RDFFR_p_f = SVEPredicateReadFromFFR_UnpredicatedFixed
};

enum SVEPredicateTestOp {
  SVEPredicateTestFixed = 0x2510C000,
  SVEPredicateTestFMask = 0xFF3FC210,
  SVEPredicateTestMask = 0xFFFFC21F,
  PTEST_p_p = SVEPredicateTestFixed | 0x00400000
};

enum SVEPredicateZeroOp {
  SVEPredicateZeroFixed = 0x2518E400,
  SVEPredicateZeroFMask = 0xFF3FFFF0,
  SVEPredicateZeroMask = 0xFFFFFFF0,
  PFALSE_p = SVEPredicateZeroFixed
};

enum SVEPropagateBreakOp {
  SVEPropagateBreakFixed = 0x2500C000,
  SVEPropagateBreakFMask = 0xFF30C000,
  SVEPropagateBreakMask = 0xFFF0C210,
  BRKPA_p_p_pp = SVEPropagateBreakFixed,
  BRKPB_p_p_pp = SVEPropagateBreakFixed | 0x00000010,
  BRKPAS_p_p_pp = SVEPropagateBreakFixed | 0x00400000,
  BRKPBS_p_p_pp = SVEPropagateBreakFixed | 0x00400010
};

enum SVEPropagateBreakToNextPartitionOp {
  SVEPropagateBreakToNextPartitionFixed = 0x25184000,
  SVEPropagateBreakToNextPartitionFMask = 0xFFBFC210,
  SVEPropagateBreakToNextPartitionMask = 0xFFFFC210,
  BRKN_p_p_pp = SVEPropagateBreakToNextPartitionFixed,
  BRKNS_p_p_pp = SVEPropagateBreakToNextPartitionFixed | 0x00400000
};

enum SVEReversePredicateElementsOp {
  SVEReversePredicateElementsFixed = 0x05344000,
  SVEReversePredicateElementsFMask = 0xFF3FFE10,
  SVEReversePredicateElementsMask = 0xFF3FFE10,
  REV_p_p = SVEReversePredicateElementsFixed
};

enum SVEReverseVectorElementsOp {
  SVEReverseVectorElementsFixed = 0x05383800,
  SVEReverseVectorElementsFMask = 0xFF3FFC00,
  SVEReverseVectorElementsMask = 0xFF3FFC00,
  REV_z_z = SVEReverseVectorElementsFixed
};

enum SVEReverseWithinElementsOp {
  SVEReverseWithinElementsFixed = 0x05248000,
  SVEReverseWithinElementsFMask = 0xFF3CE000,
  SVEReverseWithinElementsMask = 0xFF3FE000,
  REVB_z_z = SVEReverseWithinElementsFixed,
  REVH_z_z = SVEReverseWithinElementsFixed | 0x00010000,
  REVW_z_z = SVEReverseWithinElementsFixed | 0x00020000,
  RBIT_z_p_z = SVEReverseWithinElementsFixed | 0x00030000
};

enum SVESaturatingIncDecRegisterByElementCountOp {
  SVESaturatingIncDecRegisterByElementCountFixed = 0x0420F000,
  SVESaturatingIncDecRegisterByElementCountFMask = 0xFF20F000,
  SVESaturatingIncDecRegisterByElementCountMask = 0xFFF0FC00,
  SQINCB_r_rs_sx = SVESaturatingIncDecRegisterByElementCountFixed,
  UQINCB_r_rs_uw = SVESaturatingIncDecRegisterByElementCountFixed | 0x00000400,
  SQDECB_r_rs_sx = SVESaturatingIncDecRegisterByElementCountFixed | 0x00000800,
  UQDECB_r_rs_uw = SVESaturatingIncDecRegisterByElementCountFixed | 0x00000C00,
  SQINCB_r_rs_x = SVESaturatingIncDecRegisterByElementCountFixed | 0x00100000,
  UQINCB_r_rs_x = SVESaturatingIncDecRegisterByElementCountFixed | 0x00100400,
  SQDECB_r_rs_x = SVESaturatingIncDecRegisterByElementCountFixed | 0x00100800,
  UQDECB_r_rs_x = SVESaturatingIncDecRegisterByElementCountFixed | 0x00100C00,
  SQINCH_r_rs_sx = SVESaturatingIncDecRegisterByElementCountFixed | 0x00400000,
  UQINCH_r_rs_uw = SVESaturatingIncDecRegisterByElementCountFixed | 0x00400400,
  SQDECH_r_rs_sx = SVESaturatingIncDecRegisterByElementCountFixed | 0x00400800,
  UQDECH_r_rs_uw = SVESaturatingIncDecRegisterByElementCountFixed | 0x00400C00,
  SQINCH_r_rs_x = SVESaturatingIncDecRegisterByElementCountFixed | 0x00500000,
  UQINCH_r_rs_x = SVESaturatingIncDecRegisterByElementCountFixed | 0x00500400,
  SQDECH_r_rs_x = SVESaturatingIncDecRegisterByElementCountFixed | 0x00500800,
  UQDECH_r_rs_x = SVESaturatingIncDecRegisterByElementCountFixed | 0x00500C00,
  SQINCW_r_rs_sx = SVESaturatingIncDecRegisterByElementCountFixed | 0x00800000,
  UQINCW_r_rs_uw = SVESaturatingIncDecRegisterByElementCountFixed | 0x00800400,
  SQDECW_r_rs_sx = SVESaturatingIncDecRegisterByElementCountFixed | 0x00800800,
  UQDECW_r_rs_uw = SVESaturatingIncDecRegisterByElementCountFixed | 0x00800C00,
  SQINCW_r_rs_x = SVESaturatingIncDecRegisterByElementCountFixed | 0x00900000,
  UQINCW_r_rs_x = SVESaturatingIncDecRegisterByElementCountFixed | 0x00900400,
  SQDECW_r_rs_x = SVESaturatingIncDecRegisterByElementCountFixed | 0x00900800,
  UQDECW_r_rs_x = SVESaturatingIncDecRegisterByElementCountFixed | 0x00900C00,
  SQINCD_r_rs_sx = SVESaturatingIncDecRegisterByElementCountFixed | 0x00C00000,
  UQINCD_r_rs_uw = SVESaturatingIncDecRegisterByElementCountFixed | 0x00C00400,
  SQDECD_r_rs_sx = SVESaturatingIncDecRegisterByElementCountFixed | 0x00C00800,
  UQDECD_r_rs_uw = SVESaturatingIncDecRegisterByElementCountFixed | 0x00C00C00,
  SQINCD_r_rs_x = SVESaturatingIncDecRegisterByElementCountFixed | 0x00D00000,
  UQINCD_r_rs_x = SVESaturatingIncDecRegisterByElementCountFixed | 0x00D00400,
  SQDECD_r_rs_x = SVESaturatingIncDecRegisterByElementCountFixed | 0x00D00800,
  UQDECD_r_rs_x = SVESaturatingIncDecRegisterByElementCountFixed | 0x00D00C00
};

enum SVESaturatingIncDecVectorByElementCountOp {
  SVESaturatingIncDecVectorByElementCountFixed = 0x0420C000,
  SVESaturatingIncDecVectorByElementCountFMask = 0xFF30F000,
  SVESaturatingIncDecVectorByElementCountMask = 0xFFF0FC00,
  SQINCH_z_zs = SVESaturatingIncDecVectorByElementCountFixed | 0x00400000,
  UQINCH_z_zs = SVESaturatingIncDecVectorByElementCountFixed | 0x00400400,
  SQDECH_z_zs = SVESaturatingIncDecVectorByElementCountFixed | 0x00400800,
  UQDECH_z_zs = SVESaturatingIncDecVectorByElementCountFixed | 0x00400C00,
  SQINCW_z_zs = SVESaturatingIncDecVectorByElementCountFixed | 0x00800000,
  UQINCW_z_zs = SVESaturatingIncDecVectorByElementCountFixed | 0x00800400,
  SQDECW_z_zs = SVESaturatingIncDecVectorByElementCountFixed | 0x00800800,
  UQDECW_z_zs = SVESaturatingIncDecVectorByElementCountFixed | 0x00800C00,
  SQINCD_z_zs = SVESaturatingIncDecVectorByElementCountFixed | 0x00C00000,
  UQINCD_z_zs = SVESaturatingIncDecVectorByElementCountFixed | 0x00C00400,
  SQDECD_z_zs = SVESaturatingIncDecVectorByElementCountFixed | 0x00C00800,
  UQDECD_z_zs = SVESaturatingIncDecVectorByElementCountFixed | 0x00C00C00
};

enum SVEStackFrameAdjustmentOp {
  SVEStackFrameAdjustmentFixed = 0x04205000,
  SVEStackFrameAdjustmentFMask = 0xFFA0F800,
  SVEStackFrameAdjustmentMask = 0xFFE0F800,
  ADDVL_r_ri = SVEStackFrameAdjustmentFixed,
  ADDPL_r_ri = SVEStackFrameAdjustmentFixed | 0x00400000
};

enum SVEStackFrameSizeOp {
  SVEStackFrameSizeFixed = 0x04BF5000,
  SVEStackFrameSizeFMask = 0xFFFFF800,
  SVEStackFrameSizeMask = 0xFFFFF800,
  RDVL_r_i = SVEStackFrameSizeFixed
};

enum SVEStoreMultipleStructures_ScalarPlusImmOp {
  SVEStoreMultipleStructures_ScalarPlusImmFixed = 0xE410E000,
  SVEStoreMultipleStructures_ScalarPlusImmFMask = 0xFE10E000,
  SVEStoreMultipleStructures_ScalarPlusImmMask = 0xFFF0E000,
  ST2B_z_p_bi_contiguous = SVEStoreMultipleStructures_ScalarPlusImmFixed | 0x00200000,
  ST3B_z_p_bi_contiguous = SVEStoreMultipleStructures_ScalarPlusImmFixed | 0x00400000,
  ST4B_z_p_bi_contiguous = SVEStoreMultipleStructures_ScalarPlusImmFixed | 0x00600000,
  ST2H_z_p_bi_contiguous = SVEStoreMultipleStructures_ScalarPlusImmFixed | 0x00A00000,
  ST3H_z_p_bi_contiguous = SVEStoreMultipleStructures_ScalarPlusImmFixed | 0x00C00000,
  ST4H_z_p_bi_contiguous = SVEStoreMultipleStructures_ScalarPlusImmFixed | 0x00E00000,
  ST2W_z_p_bi_contiguous = SVEStoreMultipleStructures_ScalarPlusImmFixed | 0x01200000,
  ST3W_z_p_bi_contiguous = SVEStoreMultipleStructures_ScalarPlusImmFixed | 0x01400000,
  ST4W_z_p_bi_contiguous = SVEStoreMultipleStructures_ScalarPlusImmFixed | 0x01600000,
  ST2D_z_p_bi_contiguous = SVEStoreMultipleStructures_ScalarPlusImmFixed | 0x01A00000,
  ST3D_z_p_bi_contiguous = SVEStoreMultipleStructures_ScalarPlusImmFixed | 0x01C00000,
  ST4D_z_p_bi_contiguous = SVEStoreMultipleStructures_ScalarPlusImmFixed | 0x01E00000
};

enum SVEStoreMultipleStructures_ScalarPlusScalarOp {
  SVEStoreMultipleStructures_ScalarPlusScalarFixed = 0xE4006000,
  SVEStoreMultipleStructures_ScalarPlusScalarFMask = 0xFE00E000,
  SVEStoreMultipleStructures_ScalarPlusScalarMask = 0xFFE0E000,
  ST2B_z_p_br_contiguous = SVEStoreMultipleStructures_ScalarPlusScalarFixed | 0x00200000,
  ST3B_z_p_br_contiguous = SVEStoreMultipleStructures_ScalarPlusScalarFixed | 0x00400000,
  ST4B_z_p_br_contiguous = SVEStoreMultipleStructures_ScalarPlusScalarFixed | 0x00600000,
  ST2H_z_p_br_contiguous = SVEStoreMultipleStructures_ScalarPlusScalarFixed | 0x00A00000,
  ST3H_z_p_br_contiguous = SVEStoreMultipleStructures_ScalarPlusScalarFixed | 0x00C00000,
  ST4H_z_p_br_contiguous = SVEStoreMultipleStructures_ScalarPlusScalarFixed | 0x00E00000,
  ST2W_z_p_br_contiguous = SVEStoreMultipleStructures_ScalarPlusScalarFixed | 0x01200000,
  ST3W_z_p_br_contiguous = SVEStoreMultipleStructures_ScalarPlusScalarFixed | 0x01400000,
  ST4W_z_p_br_contiguous = SVEStoreMultipleStructures_ScalarPlusScalarFixed | 0x01600000,
  ST2D_z_p_br_contiguous = SVEStoreMultipleStructures_ScalarPlusScalarFixed | 0x01A00000,
  ST3D_z_p_br_contiguous = SVEStoreMultipleStructures_ScalarPlusScalarFixed | 0x01C00000,
  ST4D_z_p_br_contiguous = SVEStoreMultipleStructures_ScalarPlusScalarFixed | 0x01E00000
};

enum SVEStorePredicateRegisterOp {
  SVEStorePredicateRegisterFixed = 0xE5800000,
  SVEStorePredicateRegisterFMask = 0xFFC0E010,
  SVEStorePredicateRegisterMask = 0xFFC0E010,
  STR_p_bi = SVEStorePredicateRegisterFixed
};

enum SVEStoreVectorRegisterOp {
  SVEStoreVectorRegisterFixed = 0xE5804000,
  SVEStoreVectorRegisterFMask = 0xFFC0E000,
  SVEStoreVectorRegisterMask = 0xFFC0E000,
  STR_z_bi = SVEStoreVectorRegisterFixed
};

enum SVETableLookupOp {
  SVETableLookupFixed = 0x05203000,
  SVETableLookupFMask = 0xFF20FC00,
  SVETableLookupMask = 0xFF20FC00,
  TBL_z_zz_1 = SVETableLookupFixed
};

enum SVEUnpackPredicateElementsOp {
  SVEUnpackPredicateElementsFixed = 0x05304000,
  SVEUnpackPredicateElementsFMask = 0xFFFEFE10,
  SVEUnpackPredicateElementsMask = 0xFFFFFE10,
  PUNPKLO_p_p = SVEUnpackPredicateElementsFixed,
  PUNPKHI_p_p = SVEUnpackPredicateElementsFixed | 0x00010000
};

enum SVEUnpackVectorElementsOp {
  SVEUnpackVectorElementsFixed = 0x05303800,
  SVEUnpackVectorElementsFMask = 0xFF3CFC00,
  SVEUnpackVectorElementsMask = 0xFF3FFC00,
  SUNPKLO_z_z = SVEUnpackVectorElementsFixed,
  SUNPKHI_z_z = SVEUnpackVectorElementsFixed | 0x00010000,
  UUNPKLO_z_z = SVEUnpackVectorElementsFixed | 0x00020000,
  UUNPKHI_z_z = SVEUnpackVectorElementsFixed | 0x00030000
};

enum SVEVectorSelectOp {
  SVEVectorSelectFixed = 0x0520C000,
  SVEVectorSelectFMask = 0xFF20C000,
  SVEVectorSelectMask = 0xFF20C000,
  SEL_z_p_zz = SVEVectorSelectFixed
};

enum SVEVectorSplice_DestructiveOp {
  SVEVectorSplice_DestructiveFixed = 0x052C8000,
  SVEVectorSplice_DestructiveFMask = 0xFF3FE000,
  SVEVectorSplice_DestructiveMask = 0xFF3FE000,
  SPLICE_z_p_zz_des = SVEVectorSplice_DestructiveFixed
};

enum ReservedOp {
  ReservedFixed = 0x00000000,
  ReservedFMask = 0x1E000000,
  ReservedMask = 0xFFFF0000,
  UDF = ReservedFixed | 0x00000000
};

// Unimplemented and unallocated instructions. These are defined to make fixed
// bit assertion easier.
enum UnimplementedOp {
  UnimplementedFixed = 0x00000000,
  UnimplementedFMask = 0x00000000
};

enum UnallocatedOp {
  UnallocatedFixed = 0x00000000,
  UnallocatedFMask = 0x00000000
};

// clang-format on

#endif  // VIXL_AARCH64_CONSTANTS_AARCH64_H_
