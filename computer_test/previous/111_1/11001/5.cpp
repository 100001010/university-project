#include<iostream>
using namespace std;
int main(){
	int num,boolen,i=1;
	cin>>num;

	while(num>0){
		boolen+=num%2*i;
		num/=2;
		i*=10;
	}
	cout<<boolen;
	return 0;
}