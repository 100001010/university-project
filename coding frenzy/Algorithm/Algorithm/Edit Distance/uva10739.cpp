#include<iostream>
#include<string>
#include<algorithm>
using namespace std;
int main(){
    #ifdef fre
        freopen("in.txt","r",stdin);
        freopen("out.txt","w",stdout);
    #endif
    int n=1;
    string b;cin>>b;
    while(cin>>b){
        string e = string(b.rbegin(), b.rend());
        // if(b.size()%2==0){
        //     e = b.substr(b.size()/2, b.size()/2);
        //     b = b.substr(0, b.size()/2);
        //     //reverse(e.begin(),e.end());
        // }else{
        //     e = b.substr(b.size()/2+1, b.size());
        //     b = b.substr(0, b.size()/2+1);
        //     //reverse(e.begin(),e.end());
        // }
        // e=b;

        int **p= new int *[b.size()+1];
        for(int i=0;i<b.size()+1;i++)
            p[i]=new int[e.size()+1];

        for(int i=0;i<b.size()+1;i++)
            p[i][0]=i;
        for(int i=0;i<e.size()+1;i++)
            p[0][i]=i;

        for(int i=1;i<=b.size();i++){
            for(int j=1;j<=e.size();j++){
                //cout << b[i-1] << " " << e[j-1] << endl;
                //cout << (b[i-1]==e[j-1]) << endl<< endl;
                if(b[i-1]==e[j-1]){
                    //cout<<
                    // assert()
                    p[i][j]=p[i-1][j-1];
                }
                else{
                    p[i][j]=min({p[i-1][j-1],p[i][j-1],p[i-1][j]})+1;
                }
                
            }
        }
        // cout<<b<<endl<<e<<endl;
        // cout<<" "<<0<<b;
        // for(int i=0;i<b.size()+1;i++){
            
        //     for(int j=0;j<e.size()+1;j++)
        //         cout<<p[i][j]<<" ";
            
        //     cout<<endl;
        //     if(i<b.size())
        //         cout<<e[i];
        // }
        cout<<"Case "<<n<<": "<<(p[b.size()][e.size()]>>1)<<endl;
        n++;
    }
}
