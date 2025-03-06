#include<bits/stdc++.h>
using namespace std;

int N, L, R, ny, nx;
int m[51][51];
int visited[51][51];
int dy[4] = {-1, 0, 1, 0};
int dx[4] = {0, 1, 0, -1};
vector<pair<int, int>> v;
int temp_sum;
int res;

void dfs(int y, int x){
	for (int i = 0; i < 4; i++){
		ny = y + dy[i];
		nx = x + dx[i];
		if (ny < 0 || nx < 0 || ny >= N || nx >= N) continue;
		if (visited[ny][nx]) continue;
		if (abs(m[ny][nx] - m[y][x]) >= L && abs(m[ny][nx] - m[y][x]) <= R){
			v.push_back({ny, nx});
			temp_sum += m[ny][nx];
			visited[ny][nx] = 1;
			dfs(ny, nx);
		}		
	}
}

int main(){
	ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
	cin >> N >> L >> R;
	
	for (int i = 0; i < N; i++){
		for (int j = 0; j < N; j++){
			cin >> m[i][j];
		}
	}
		
	for (int i = 0; i < 2000; i++){
		int isOk = 0;
		fill(&visited[0][0], &visited[0][0] + 51 * 51, 0);
		for (int j = 0; j < N; j++){
			for (int k = 0; k < N; k++){
				if (!visited[j][k]){
					v.clear();
					temp_sum = m[j][k];
					visited[j][k] = 1;
					v.push_back({j, k});
					dfs(j, k);
					if (v.size() == 1) continue;
					for(pair<int, int> it : v){
						m[it.first][it.second] = temp_sum / v.size();
						isOk = 1;
					}
				}
			}
		}
		
		if (!isOk) break;
		res++;
	}
	
	cout << res << endl;
	
	return 0;
}