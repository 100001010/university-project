#include<iostream>
using namespace std;
int main(){
	int f,e;
	while(cin>>f>>e){
		if(!e)break;
		int s=1,n=0;
		while(s*s<=e){
			if(s*s>=f)
			n++;
			s++;
		}	
			cout<<n<<endl;
	}
	return 0;
}