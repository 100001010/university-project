
#include<iostream>
using namespace std;
int main(void)
{
	int f,e,t,n=0;	cin>>f;
	while(cin>>f>>e){
		t=0;
		n++;
		for(f=f/2*2+1;f<=e;f+=2)
			t+=f;
		cout<<"Case "<<n<<": "<<t<<endl;
	}
	return 0;
}
