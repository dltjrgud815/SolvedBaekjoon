#include <string>
#include <vector>
#include<bits/stdc++.h>

using namespace std;

int players_num = 24;
int active_num;

typedef struct {
	int s_time = 0;
}server;

vector<server> servers;

void refresh_server(int time, int k){
	for (int i = 0; i < active_num; i++){
		if ((servers[i].s_time + k) <= time){
			servers.erase(servers.begin() + i);
			i--;
			active_num--;
		} 
	}
}

int solution(vector<int> players, int m, int k) {
    int answer = 0;
    
    for (int i = 0; i < players_num; i++){
    	refresh_server(i, k);
    	if (players[i] / m == 0) continue;
    	if (players[i] / m > active_num){
            int repeat = (players[i] / m) - active_num;
    		for (int j = 0; j < repeat; j++){
    			answer++;
                active_num++;
				server new_server;
    			new_server.s_time = i;
    			servers.push_back(new_server);
			}
		}else {
			continue;
		}
	}
    
    return answer;
}