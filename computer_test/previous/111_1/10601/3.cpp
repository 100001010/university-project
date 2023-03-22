#include<iostream>
using namespace std;
int main(){
	int n;
	while(cin>>n){
		for (int i = 1; i <= n; ++i)
		{
			for (int j = 0; j < i; ++j)
			{
				cout<<i;
			}
		}
		cout<<n+1<<endl;
	}

}