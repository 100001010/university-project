#include<iostream>
using namespace std;
int fibonacci(int);
int main(){
	int n;
	cin>>n;

	for(int i=1; i<=n;i++)
		cout<<fibonacci(i)<<" ";
	return 0;
}

int fibonacci(int num){
	if ( num==1|| num==2)
		return 1;
	else 
		return fibonacci(num-1)+fibonacci(num-2);
}
