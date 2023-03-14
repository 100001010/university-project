#include<stack>
#include<queue>
#include<iostream>
using namespace std;
int main(){
    #ifdef fre
        freopen("in.txt","r",stdin);
        freopen("out.txt","w",stdout);
    #endif
    int bool_out;
    while(cin>>bool_out&&bool_out!=0){
        while(1){
            queue<int>target;
            int temp;
            cin>>temp;
            target.push(temp);
            if(target.front()==0){
                
                cout<<endl;
                break;
            }
                
            for(int i=1;i<bool_out;i++){
                cin>>temp;
                target.push(temp);
            }


            stack<int> a;
            for(int i=1;i<=bool_out;i++){
                a.push(i);
                while(!target.empty()&&!a.empty()&&target.front()==a.top()){
                    target.pop();
                    a.pop();
                }
            }
            //1 2 3 4 5 6 7
            //1 3 2 5 4 7 6
            if(a.empty())
                cout<<"Yes"<<endl;  
            else
                cout<<"No"<<endl;
                
        }
        
    }

}