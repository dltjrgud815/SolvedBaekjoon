#include<bits/stdc++.h>
using namespace std;

int N;
int a[1000004], ret[1000004];
stack<int> s;


int main(){
    cin >> N;
    memset(ret, -1, sizeof(ret));
    for (int i = 0; i < N; i++){
        cin >> a[i];
        while (s.size() && a[s.top()] < a[i]){
            ret[s.top()] = a[i];
            s.pop();
        }
        s.push(i);
    }

    for (int i = 0; i < N; i++) cout << ret[i] << " ";
    return 0;
}