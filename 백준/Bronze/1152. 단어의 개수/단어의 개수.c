#include <stdio.h>
#include <string.h>

int main(void) {
    char str[1000001] = {'\0'};
    int wordcnt = 0;
    gets(str);
    int strlength = strlen(str);
    for (int i = 0 ; i < strlength; i++) {
        if (str[i] == ' ' && (i == 0 || i == strlength - 1)) continue;
        if (str[i] == ' ') wordcnt++;
    }

    if (!(strlength == 1 && str[0] == ' ')) {
        wordcnt ++;
    }
    printf("%d", wordcnt);
}