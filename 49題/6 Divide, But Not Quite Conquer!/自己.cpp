
#include<iostream>
using namespace std;
int main(){
	int f,e;
	while(cin>>f>>e){
		int fe=e;
		if(e==1) {
			cout<<"Boring!\n";
			continue;
		}
		while(e<f)	e*=fe;
		if(e==f){
			cout<<f<<" ";
			while(f!=1)
			{
				if(f==fe){
					cout<<1;
					break;
				}
				cout<<f/fe<<" ";
				f=f/fe;
			}
		}
		else
			cout<<"Boring!";
		cout<<endl;
	}	
  return 0;
}

