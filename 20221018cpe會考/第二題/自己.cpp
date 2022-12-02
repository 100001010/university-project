#include <iostream>
using namespace std;
int main(){
	int d0,m0,y0,d1,m1,y1; char c;cin>>y0;int kase=0;
	while(cin>>d1>>c>>m1>>c>>y1>>d0>>C>>m0>>c>>y0){
		cout<<"Case #"<<++kase<<": ";
		int v0=y0*10000+m0*100+d0;
		int v1=y1*10000+m1*100+d1;
		if(v1<v0)	{cout<<"Invalid birth date"<<endl;  continue;}
		if((v1-v0)>=1310000) {cout<<"Check birth date"<<endl;continue;}
		cout<<(v1-v0)/10000<<endl;
	}
	return 0;
}