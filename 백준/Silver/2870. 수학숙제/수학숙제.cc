#include<bits/stdc++.h>
using namespace std;

int M;
vector<string> vc;
vector<string> res;

bool cmp(string a, string b){
    if (a.size() == b.size()){
        for (int i = 0; i < a.size(); i++){
            if (a[i] == b[i]) continue;
            return a[i] < b[i];
        }
    }
    return a.size() < b.size();
}

string clear_zero(string input){
    string re;
    bool isNum = false;
    for (int i = 0; i < input.size() ; i++){
        if (input[i] != '0')
            isNum = true;
        if (isNum)
            re += input[i];
    }
    if (re == "")
        return "0";
    else
        return re;
}

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
    cin >> M;
    for (int i = 0; i < M; i++){
        string temp;
        cin >> temp;
        vc.push_back(temp);
    }
    for (int i = 0; i < M; i++){
        string num_str;
        for (int j = 0; j < vc[i].size(); j++){
            if (vc[i][j] >= '0' && vc[i][j] <= '9'){
                num_str += vc[i][j];
            }
            else{
                if (num_str == "") continue;
                res.push_back(clear_zero(num_str));
                num_str = "";
            }
        }
        if (num_str != ""){
            res.push_back(clear_zero(num_str));
        }
    }
    sort(res.begin(), res.end(), cmp);
    for(string i : res) cout << i << "\n";

    return 0;
}