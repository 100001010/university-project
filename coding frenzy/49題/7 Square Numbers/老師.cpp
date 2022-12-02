#include<iostream>
#include<cmath>
using namespace std;
int main(){
	int a,b;
	while(cin>>a>>b,a+b){
		int ans=0;
		for (int i=a;i<=b;i++){
			int k=sqrt(i);
			ans+=(k*k==i);
		}
		cout<<ans<<endl;
	}
	return 0;
}