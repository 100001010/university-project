#include<iostream>
using namespace std;
int main(){
	int n;
	while(cin>>n){
		cout<<"星期日\t星期一\t星期二\t星期三\t星期四\t星期五\t星期六\n";
		for (int i = 0; i < (n==7?0:n); ++i)
		{
			cout<<"\t";
		}
		for (int i = 1; i <=31; ++i){
			if((i+n-1)%7==6)cout<<i<<"\n";
			else		  cout<<i<<"\t";
		}
		cout<<endl;
	}

}