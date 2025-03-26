#include <bits/stdc++.h>

using namespace std;

int solution(vector<int> schedules, vector<vector<int>> timelogs, int startday) {
    int answer = 0;
    
    for (int i = 0; i < schedules.size(); i++){
        int s_h = schedules[i] / 100;
        int s_m = schedules[i] % 100;
        s_m += 10;
        if (s_m >= 60){
            s_h++;
            s_m -= 60;
        }
        int s = s_h * 100 + s_m;
        
        int temp_day = startday;
        int is_pass = 1;
        
        for (int j = 0; j < timelogs[i].size(); j++){
            if (temp_day % 7 == 0 || temp_day % 7 == 6){
                temp_day++;
                continue;
            }
            
            if (timelogs[i][j] <= s) temp_day++;
            else{
                is_pass = 0;
                break;
            } 
        }
        
        if (is_pass) answer++;
    }
    
    return answer;
}