#include <stdio.h>
#include <string.h>

int main(void) {
    int alphabet['z' - 'a' + 1] = {-1};
    char s;
    int count = 0;

    memset(alphabet, -1, sizeof(alphabet));

    do {
        (void)scanf("%c", &s);
        if (alphabet[s - 'a'] < 0) {
            alphabet[s - 'a'] = count;
        }
        count ++;
    } while (s != '\n');

    for (int i = 0; i < sizeof(alphabet) / sizeof(alphabet[0]); i++) {
        printf("%d ",alphabet[i]);
    }
}