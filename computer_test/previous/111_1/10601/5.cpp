#include<iostream>
using namespace std;
int main(){
	int y,m,d;
	int p[11]={31,28,31,30,31,30,31,31,30,31,30};
	while(cin>>y>>m>>d){
		int total=0;
		if (y%4==0){
			p[1]=29;
			if (y%100==0){
				p[1]=28;
				if (y%1000==0){
					p[1]=29;
				}
			}
		}
		for (int i = 0; i < m-1; ++i)
		{
			total+=p[i];
		}
		cout<<total+d;
	}

}