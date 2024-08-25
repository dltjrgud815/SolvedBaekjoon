#include <stdio.h>

int dp[45] = {0};
int fibonacci(int n){
    if (n == 1 || n == 2)
        return 1;

    if(dp[n] != 0)
        return dp[n];
    else
        return dp[n] = fibonacci(n - 1) + fibonacci(n - 2);
}

int main(void) {
    int N;
    scanf("%d", &N);
    printf("%d", fibonacci(N));

    return 0;
}