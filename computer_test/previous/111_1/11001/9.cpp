#include<iostream>
using namespace std;
int pow(int);
int main(){
	int n,sum=0;
	cin>>n;
	for (int i = 0; i <= n; ++i)
	{
		sum+=pow(i);
	}
	cout<<sum;
}

int pow(int n){
	int k=n;
	for (int i = 1; i < k; ++i)
	{
		n*=k;
	}
	return n;
}
