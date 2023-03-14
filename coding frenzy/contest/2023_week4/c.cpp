#include<iostream>
#include<vector>
#include<algorithm>
using namespace std;
int main(){
    #ifdef fre
        freopen("in.txt","r",stdin);
        freopen("out.txt","w",stdout);
    #endif
    int n;cin>>n;
    while(cin>>n){
        int *p=new int[n];
        int ans=0,f=0,e=0;
        for(int i=0;i<n;i++){
            int t;
            cin>>t;
            
            if(find(p+f,p+e,t)){
                if((e-f+1)>ans)
                    ans=e-f+1;
                f=*find(p+f,p+n,t)+1;
                p[i]=t;
                e++;
                
            }else{
                p[i]=t;
                e++;
                
            }
        }
        if((e-f+1)>ans)
            ans=e-f+1;
        cout<<ans<<endl;
            
        
        
    }
}