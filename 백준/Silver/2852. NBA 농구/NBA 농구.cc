#include <bits/stdc++.h>
using namespace std;

vector<string> split(const string& input, const string delimiter){
    vector<string> result;
    auto start = 0;
    auto end = input.find(delimiter);
    while (end != string::npos){
        result.push_back(input.substr(start, end - start));
        start = end + delimiter.size();
        end = input.find(delimiter, start);
    }
    result.push_back(input.substr(start));
    return result;
}

int N;
int time_arr[101][2];
int score_arr[101];
int res[3][2];
int score[3];
const int play_max_time = 48;

int main(){
    //ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
    cin >> N;

    for (int i = 0; i < N; i++){
        string temp;
        cin >> score_arr[i] >> temp;
        vector<string> temp1 = split(temp, ":");
        time_arr[i][0] = atoi(temp1[0].c_str());
        time_arr[i][1] = atoi(temp1[1].c_str());
    }

    time_arr[N][0] = play_max_time;

    for (int i = 0; i < N; i++){
        score[score_arr[i]]++;
        if (score[1] > score[2]){
            res[1][0] += (time_arr[i+1][0] - time_arr[i][0]);
            res[1][1] += (time_arr[i+1][1] - time_arr[i][1]);
            if (res[1][1] < 0){
                res[1][0]--;
                res[1][1]+=60;
            } else if (res[1][1] > 60){
                res[1][0]++;
                res[1][1]-=60;
            }
        }
        if (score[1] < score[2]){
            res[2][0] += (time_arr[i+1][0] - time_arr[i][0]);
            res[2][1] += (time_arr[i+1][1] - time_arr[i][1]);
            if (res[2][1] < 0){
                res[2][0]--;
                res[2][1]+=60;
            } else if (res[2][1] > 60){
                res[2][0]++;
                res[2][1]-=60;
            }
            
        }
    }

    for (int i = 1; i <= 2; i++){
        printf("%02d:%02d\n", res[i][0], res[i][1]);
    }

    return 0;
}