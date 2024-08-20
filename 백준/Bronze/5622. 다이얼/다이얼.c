#include <stdio.h>

int main(void) {
    int sol = 0;
    int dial[11] = {0, 0, 'A', 'D', 'G', 'J', 'M', 'P', 'T', 'W', 'Z' + 1};
    char temp;
    do {
        scanf("%c", &temp);
        for (int i = 2; i < 10; i++) {
            if ((int)temp >= dial[i] && (int)temp < dial[i + 1]) 
                sol += (i + 1);
        }
    } while(temp != '\n');

    printf("%d\n", sol);
}