#include <iostream>
#include <queue>
using namespace std;

static const int MAX = 100000;
int dist[MAX+1];
long long ways[MAX+1]; // 경로 개수를 셀 때는 int 범위 초과 가능성 고려

int main(){
    int N, K;
    cin >> N >> K;
    
    // 초기화
    for(int i=0; i<=MAX; i++){
        dist[i] = -1;   // 아직 방문 안 함
        ways[i] = 0;    
    }
    
    // 시작점 설정
    queue<int> q;
    q.push(N);
    dist[N] = 0;       // 시작점까지 거리 0
    ways[N] = 1;       // 시작점에 도달하는 방법은 1개

    while(!q.empty()){
        int x = q.front();
        q.pop();
        
        // x+1, x-1, x*2 등 다음 위치 탐색
        for(int next : {x-1, x+1, x*2}){
            if(next < 0 || next > MAX) continue;
            
            // 아직 방문하지 않은 경우
            if(dist[next] == -1){
                dist[next] = dist[x] + 1;      // 새로 방문
                ways[next] = ways[x];         // 경로 개수 = 현재 x의 경로 개수
                q.push(next);
            }
            // 이미 방문했지만, "최단 거리"가 같다면 → 또 다른 최단 경로
            else if(dist[next] == dist[x] + 1){
                ways[next] += ways[x];
            }
        }
    }
    
    cout << dist[K] << "\n";   // 최소 시간
    cout << ways[K] << "\n";   // 방법의 개수
    return 0;
}