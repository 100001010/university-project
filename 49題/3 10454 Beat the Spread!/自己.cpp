#include <iostream>
using namespace std;
int main(){
  int n;cin>>n;
  for(int i=0;i<n;i++){
  	int a,b;cin>>a>>b;
  	if(!((a+b)%2)&&(a>b) cout<<(a+b)/2<<" "<<(a+b)/2-b<<endl;
  	else                 cout<<"impossible\n";
  }
  return 0;
}