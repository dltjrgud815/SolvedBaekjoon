#include <bits/stdc++.h>
using namespace std;

int N;
int alphabet[26] = {0,};

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);

    cin >> N;
    for (int i = 0; i < N; i++){
        string temp;
        cin >> temp;
        alphabet[temp[0] - 'a']++;
    }

    string res;
    for (int i = 0; i < 26; i++){
        if (alphabet[i] >= 5){
            res += (char)(i + 'a');
        }
    }
    if (res == "")
        res = "PREDAJA";

    cout << res;
    return 0;
}