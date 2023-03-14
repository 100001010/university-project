#include<iostream>
using namespace std;
int main(){
	int s,d;cin>>s;
	while(cin>>s>>d){
		if(s<d||(s+d)%2)cout<<"impossible"<<endl;
		else cout<<(s+d)/2<<" "<<(s-d)/2<<endl;
	}
	return 0;
}
