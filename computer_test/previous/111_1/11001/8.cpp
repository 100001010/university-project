#include<iostream>
using namespace std;
int prime(int);
int main(){
	int n;
	cin>>n;
	for(int i=2;i<n;i++)
		if (prime(i))
			cout<<i<<endl;
	return 0;
}

int prime(int n){
	for (int i = 2; i < n; ++i)
	{
		if (n%i==0)
		{
			return 0;
		}
	}
	return 1;

}