#include<bits/stdc++.h>
using namespace std;

int k;
vector<char> comp_char;
char num[10] = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
int visited[10];
string min_num;
string max_num;
string cur;

void go(int cnt){
    if (cnt == k){
        min_num = min(min_num, cur);
        max_num = max(max_num, cur);
        return;
    }

    for (int i = 0; i < 10; i++){
        if(visited[i]) continue;
        if (cnt >= 0){
            switch(comp_char[cnt]){
                case '<':
                    if (cur[cnt] > num[i]) continue;
                    break;
                case '>':
                    if (cur[cnt] < num[i]) continue;
                    break;
            }
        }
        visited[i] = 1;
        cur += num[i];
        go(cnt + 1);
        visited[i] = 0;
        cur.pop_back();
    }
}

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
    cin >> k;
    for (int i = 0; i < k; i++){
        char c;
        cin >> c;
        comp_char.push_back(c);
        
    }

    for (int i = 0; i < k + 1; i++){
        min_num += '9';
        max_num += '0';
    }

    go(-1);

    cout << max_num << "\n" << min_num;
    return 0;
}