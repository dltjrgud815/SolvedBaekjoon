#include <bits/stdc++.h>
using namespace std;

int N;
string pattern_str;
vector<string> patterns;
vector<string> vc_str;
vector<string> res;

vector<string> split(const string& input, string delimiter){
    vector<string> result;
    auto start = 0;
    auto end = input.find(delimiter);
    while (end != string::npos) {
        result.push_back(input.substr(start, end - start));
        start = end + delimiter.size();
        end = input.find(delimiter, start);
    }

    result.push_back(input.substr(start));
    return result;
}

int main(){
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);

    cin >> N;
    cin >> pattern_str;
    patterns = split(pattern_str, "*");

    for (int i = 0; i < N; i++){
        string temp;
        cin >> temp;
        vc_str.push_back(temp);
    }

    int min_size = patterns[0].size() + patterns[1].size();

    for (int i = 0; i < N; i++){
        if (vc_str[i].size() < min_size){
            res.push_back("NE");
            continue;
        }

        string temp1 = vc_str[i].substr(0, patterns[0].size());
        string temp2 = vc_str[i].substr(vc_str[i].size() - patterns[1].size(), patterns[1].size());

        if (temp1 == patterns[0] && temp2 == patterns[1])
            res.push_back("DA");
        else
            res.push_back("NE");
    }
    
    for(auto it : res) cout << it << "\n";
    
    return 0;
}
