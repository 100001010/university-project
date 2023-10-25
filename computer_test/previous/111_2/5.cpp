#include<iostream>
using namespace std;
int main(){
    char ch[5];
    while(1){
      for(int i=0;i<=4;i++){
        cin>>ch[i];
      }
      if(ch[2]=='+')  cout<<(int(ch[0]-'0')*10+int(ch[1]-'0'))+(int(ch[3]-'0')*10+int(ch[4]-'0'))<<endl;
      if(ch[2]=='-')  cout<<(int(ch[0]-'0')*10+int(ch[1]-'0'))-(int(ch[3]-'0')*10+int(ch[4]-'0'))<<endl;
      if(ch[2]=='*')  cout<<(int(ch[0]-'0')*10+int(ch[1]-'0'))*(int(ch[3]-'0')*10+int(ch[4]-'0'))<<endl;
      if(ch[2]=='/')  cout<<(int(ch[0]-'0')*10+int(ch[1]-'0'))/(int(ch[3]-'0')*10+int(ch[4]-'0'))<<endl;
    }
}
