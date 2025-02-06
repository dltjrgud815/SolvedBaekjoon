#include <bits/stdc++.h>
using namespace std;

int N;
int res = 0;

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);

    cin >> N;
    for (int i = 0; i < N; i++){
        string temp;
        cin >> temp;
        stack<char> st;
        for(char cc : temp) {
            if (st.size() != 0 && st.top() == cc) st.pop();
            else st.push(cc);
        }
        if (st.size() == 0) res++;
    }

    cout << res;
    return 0;
}