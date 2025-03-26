#include <bits/stdc++.h>

int package_arr[100][10];
int is_right = 1;

using namespace std;

int solution(int n, int w, int num) {
    int answer = 0;
    int temp = 1;
    for (int i = 99; i >= 0; i--){
        if (is_right){
            for (int j = 0; j < w; j++){
                if (temp > n) continue;
                package_arr[i][j] = temp;
                temp++;
            }
        }
        else {
            for (int j = w - 1; j >= 0; j--){
                if (temp > n) continue;
                package_arr[i][j] = temp;
                temp++;
            }
        }
        is_right = !is_right;
    }
    
    for (int i = 0; i < 100; i++){
        for (int j = 0; j < w; j++){
            if (num != package_arr[i][j]) continue;
            for (int k = i; k >= 0; k--){
                if (package_arr[k][j] == 0) break;
                answer++;
            }
        }
    }
    
    return answer;
}