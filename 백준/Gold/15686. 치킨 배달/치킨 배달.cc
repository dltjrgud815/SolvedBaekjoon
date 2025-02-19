#include<bits/stdc++.h>
using namespace std;

int N, M;
int map_arr[51][51];
vector<pair<int, int>> chicken;
vector<pair<int, int>> house;
int min_distance = 1e6;

void combi(int start, vector<pair<int,int>> &b){
    if(b.size() == M){
        int temp_distance = 0;
        for (int i = 0; i < house.size(); i++){
            int distance = 1e6;
            for (int j = 0; j < b.size(); j++){
                int x = abs(house[i].first - b[j].first);
                int y = abs(house[i].second - b[j].second);
                distance = min(distance, x + y);
            }
            temp_distance += distance;
        }
        min_distance = min(min_distance, temp_distance);
        return;
    }
    for (int i = start + 1; i < chicken.size(); i++){
        b.push_back({chicken[i].first, chicken[i].second});
        combi(i, b);
        b.pop_back();
    }
    return;
}

int main(){
    ios_base::sync_with_stdio(false); cin.tie(0); cout.tie(0);
    cin >> N >> M;
    for (int i = 0; i < N; i++){
        for (int j = 0; j < N; j++){
            cin >> map_arr[i][j];
            if (map_arr[i][j] == 2)
                chicken.push_back({i, j}); 
            else if (map_arr[i][j] == 1)
                house.push_back({i, j});
        }
    }

    vector<pair<int, int>> select;
    combi(-1, select);
    cout << min_distance << "\n";

    return 0;
}
