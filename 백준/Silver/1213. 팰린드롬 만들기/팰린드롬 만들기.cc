#include <bits/stdc++.h>
using namespace std;

string input_str;
int alphabet[26] = {0,};
int input_size = 0;
int is_odd = 0;
int is_even = 0;
string result_str;
string result_half_str;
string odd_str;

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
    
    cin >> input_str;
    input_size = input_str.size();
    for (int i = 0; i < input_str.size(); i++){
        alphabet[input_str[i] - 'A']++;
    }
    for (int i = 0; i < 26; i++){
        if (alphabet[i] % 2 == 0)
            is_even ++;
        else
            is_odd ++;
    }

    if (input_size % 2 == 0){
        if (is_odd > 0){
            cout << "I'm Sorry Hansoo";
            return 0;
        }
    }
    else {
        if (is_odd > 1 || is_odd == 0){
            cout << "I'm Sorry Hansoo";
            return 0;
        }
    }

    for (int i = 0; i < 26; i++){
        for (int j = 0; j < alphabet[i] / 2; j++){
                result_half_str.push_back('A' + i);
        }
        if (alphabet[i] % 2 == 1){
            odd_str += 'A' + i;
        }
    }
    result_str += result_half_str;
    result_str += odd_str;
    reverse(result_half_str.begin(), result_half_str.end());
    result_str += result_half_str;

    cout << result_str;
    return 0;
}