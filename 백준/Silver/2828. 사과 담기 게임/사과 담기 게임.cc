#include<bits/stdc++.h>
using namespace std;

int N, M, J;
int cur_b_pos = 1;
int cnt = 0;
int prev_pos = 1;
int apple_pos[20];
bool basket_pos[21];

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
    cin >> N >> M >> J;
    for (int i = 1; i <= M; i++){
        basket_pos[i] = true;
    }
    for (int i = 0; i < J; i++){
        cin >> apple_pos[i];
    }
    for (int i = 0; i < J; i++){
        if (basket_pos[apple_pos[i]]){
            prev_pos = apple_pos[i];
            continue;
        }
        else{
            for (int j = 1; j <= N; j++){
                fill(&basket_pos[0], &basket_pos[20], false);
                if (prev_pos < apple_pos[i]){
                    cur_b_pos ++;
                    for (int k = 0; k < M; k++){
                        basket_pos[cur_b_pos + k] = true;
                    }
                }
                else {
                    cur_b_pos --;
                    for (int k = 0; k < M; k++){
                        basket_pos[cur_b_pos + k] = true;
                    }
                }
                cnt++;
                if (basket_pos[apple_pos[i]]){
                    prev_pos = apple_pos[i];
                    break;
                }
            }
        }
    }

    cout << cnt << "\n";
    return 0;
}