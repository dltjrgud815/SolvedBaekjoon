#include <bits/stdc++.h>
using namespace std;

string input_word;

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);

    cin >> input_word;
    int res = 1;
    int word_cnt = input_word.size();
    for (int i = 0; i < (word_cnt / 2); i++){
        if (input_word[i] == input_word[word_cnt - 1 - i]){
            continue;
        }
        else{
            res = 0;
            break;
        }
    }
        
    cout << res;
    return 0;
}