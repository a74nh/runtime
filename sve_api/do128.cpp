#include <sys/prctl.h>
#include <stdio.h>
#include <unistd.h>

int main(void)
{
 int maxVectorLength = 128 >> 3;
 int ret = prctl(PR_SVE_SET_VL, (maxVectorLength | PR_SVE_VL_INHERIT), 0, 0, 0);

 if (ret==-1)
 {
         printf("prctl failed: %d\n",ret);
 }
 char *program = "/usr/bin/zsh";
 char* argv[] = {};
 execl(program, "zsh", 0);

}
