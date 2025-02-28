#include<bits/stdc++.h>
using namespace std;

int N;
string input;
long long res = LLONG_MIN;
queue<char> q;

long long cal(long long a, long long b, char expression){
    long long temp = 0;
    switch(expression){
        case '+':
            temp = a + b;
            return temp;
        case '-':
            temp = a - b;
            return temp;
        case '*':
            temp = a * b;
            return temp;
        default:
            return LLONG_MIN;
    }
}

long long cal_parsing(string s) {
    long long temp = 0;
    int cnt = 0;
    string clean_str;

    if (s[0] != '('){
        temp = (s[0] - '0');
        cnt++;
    } else if (s[0] == '('){
        temp = cal(s[1]-'0', s[3]-'0', s[2]);
        cnt += 5;
    }

    while (cnt < s.size()){
        if (s.size() - cnt >= 2){
            if (s[cnt+1] == '('){
                temp = cal(temp, cal(s[cnt+2]-'0', s[cnt+4]-'0', s[cnt+3]),s[cnt]);
                cnt+=6;
            }else{
                temp = cal(temp, s[cnt+1]-'0', s[cnt]);
                cnt+=2;
            }
        }
    }

    return temp;
}

void go(int idx, string s){
    if (idx > s.size() || s.size() - idx < 3) return;

    string temp = s;
    temp.insert(idx, "(");
    temp.insert(idx + 4, ")");
    res = max(res, cal_parsing(temp));
    for (int i = idx + 6; i < temp.size(); i+=2){
        go(i, temp);
    }
}

int main(){
    ios_base::sync_with_stdio(false);
    cin >> N;
    cin >> input;

    if (input.size() == 1){
        cout << input[0] -'0' << "\n";
        return 0;
    }

    for (int i = 0; i < input.size() - 2; i+=2){
        go(i, input);
    }

    cout << res << "\n";

    return 0;
}