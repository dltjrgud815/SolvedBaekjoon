#include<bits/stdc++.h>
using namespace std;

int N;

void star(int y, int x, int n){
    if ((y / n) % 3 == 1 && (x / n) % 3 == 1){
        cout << ' ';
    }else{
        if(n / 3 == 0) {
            cout << '*';
        }
        else{
            star(y, x, n/3);
        }
    }
}

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
    cin >> N;

    for (int i = 0; i < N; i++){
        for (int j = 0; j < N; j++){
            star(i, j, N);
        }
        cout << "\n";
    }

    return 0;
}