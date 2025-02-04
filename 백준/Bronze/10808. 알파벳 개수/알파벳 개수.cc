#include <bits/stdc++.h>
using namespace std;

string input;
int alphabet[26] = {0,};

int main(){
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);
    
    cin >> input;
    for (int i = 0 ; i < input.length(); i++){
        alphabet[input[i] - 'a']++;
    }
    for(auto it : alphabet) cout << it << " ";
}