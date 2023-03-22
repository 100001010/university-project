#include<iostream>
using namespace std;

int main(){
	int a,M,m;
	cin>>a;
	m=a;
	M=a;
	while(cin>>a,a!=-1)
		if(m>a)
			m=a;
		else if(M<a)
			M=a;
	cout<<m<<endl<<M;
}