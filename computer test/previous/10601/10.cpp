#include<bits/stdc++.h>
using namespace std;
int main(){
	int y,m,d;
	int mm[12]={31,28,31,30,31,30,31,31,30,31,30,31};
	while(cin>>y>>m>>d){
		int ans=5;
		if (y>=2000){
			for(int i=2000;i<y;i++){
				if(i%1000==0)
					ans++;
				else if(i%100==0)
					ans=ans;
				else if(i%4==0)
					ans++;
				ans++;;
			}
			if(y%1000==0)
				mm[1]=29;
			else if(y%100==0)
				mm[1]=mm[1];
			else if(y%4==0)
				mm[1]=29;
			for (int i = 0; i < m-2; ++i){
				ans+=mm[i];
			}

			cout<<(ans+d)%7;
		}else{

		}
	}


}