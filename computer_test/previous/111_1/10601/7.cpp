#include<bits/stdc++.h>
using namespace std;
int main(){
	int a;

	while(cin>>a){
		int M=a,m=a;
		while(cin>>a,a!=-1)
			if (a>M)
				M=a;
			else if(a<m)
				m=a;
		cout<<M<<" "<<m;
	}

}