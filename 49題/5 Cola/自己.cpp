#include<iostream>
using namespace std;
int main(){
  int f;
  while(cin>>f){
    int e=0,t=0;
    while(f){
      e+=f;   t+=f; f=0;
      f=e/3;  e%=3;
    }
    cout<<(e!=2 ?t:++t)<<endl;
  }
  return 0;
}
