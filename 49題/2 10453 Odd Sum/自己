#include<iostream>
using namespace std;
int main(){
	int a,b,n;	cin>>n;
	for(int i=1;i<=n;i++){
		cin>>a>>b;
		if(b-a){				//nlnl
			if(!(a%2))	a++;
			if(!(b%2))	b--;
			printf("Case %d: %d\n",i,(a+b)*((b-a)/2+1)/2 );
		}
		else{
			if(a%2)	printf("Case %d: %d\n",i,a );
			else	printf("Case %d: %d\n",i,0 );
		}
	}
	//temp  輔助變數
	return 0;
}