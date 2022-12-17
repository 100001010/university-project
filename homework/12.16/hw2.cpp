//11360465-田咏帟-wh2
#include<iostream>
using namespace std;
int main(){
	int num;
	while(cin>>num){
		int boolen=0,i=1;
		while(num>0){
			boolen+=num%4*i;
			num/=4;
			i*=10;
		}
		cout<<boolen<<endl;
	
	}

	return 0;
}

