#include <bits/stdc++.h>
using namespace std;

vector<int> low;

int main(){
    for (int i = 0; i < 9; i++){
        int temp;
        cin >> temp;
        low.push_back(temp);
    }

    sort(low.begin(), low.end());
    do{
        int temp_sum = 0;
        for(int i = 0; i < 7; i++){
            temp_sum += low[i];
        }
        if(temp_sum == 100){
            for(int i = 0; i < 7; i++){
                cout << low[i] << "\n";
            }
            break;
        }
    }while(next_permutation(low.begin(), low.end()));
    return 0;
}