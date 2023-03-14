#include<vector>
#include<queue>
#include<iostream>
using namespace std;
int main(){
    #ifdef fre
        freopen("in.txt","r",stdin);
        freopen("out.txt","w",stdout);
    #endif
    int c,n,m;cin>>c;
    
    for(int k=0;k<c;k++){
        cin>>n>>m;
        int ans=0;
        vector<int> p;
        for(int i=0;i<n;i++){
            int t;cin>>t;
            p.push_back(t);
        }
        for(int i=9;i>0;i++){
            
            for(int k=0;k<n;k++){
                auto it = find(p.begin(), p.end(), 1);
                if(it!=p.end()){
                    *it = 0;
                    ans++;
                    if(it - p.begin()==m)
                        cout<<ans<<endl;
                }
                
            }
        }
    }
}
//     0 1 2 3 4
// arr 1 2 3 4 5
//       ^