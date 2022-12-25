#include<iostream>
using namespace std;
int main(){
	int odd;
	while(cin>>odd)
		if(odd%2!=1 ||odd<0)
			continue;
		else
			break;
	cout<<(1+odd)*(odd/2+1)/2;
	return 0;
}