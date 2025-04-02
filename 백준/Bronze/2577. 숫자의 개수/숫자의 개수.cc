#include<bits/stdc++.h>
using namespace std;

int A;
int B;
int C;
int input;
int digit[10];

int main(){
    cin >> A;
    cin >> B;
    cin >> C;
    input = A * B * C;

    while (input > 0){
        digit[input%10]++;
        input /= 10;
    }

    for (auto i : digit){
        cout << i << endl;
    }

    return 0;
}