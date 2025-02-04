#include <bits/stdc++.h>
using namespace std;

string s;

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);

    getline(cin, s);
    
    for(int i = 0; i < s.size(); i++){
        if (s[i] >= 'a' && s[i] <= 'z') {
            if (s[i] > 'm')
                s[i] = s[i] - 26 + 13;
            else
                s[i] += 13;
        }
        else if (s[i] >= 'A' && s[i] <= 'Z'){
            s[i] += 13;
            if (s[i] > 'Z')
                s[i] = s[i] - 'Z' + 'A' - 1;
        }
    }
    
    cout << s;

    return 0;
}