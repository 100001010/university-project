#include<iostream>
using namespace std;
int main(){
	int m,d;
	cin>>m>>d;
	int m_first[12]={5};
	int many[12]={31,28,31,30,31,30,31,31,30,31,30,31};
	for(int i=1;i<12;i++){
		m_first[i]=(m_first[i-1]+many[i-1])%7;
		cout<<m_first[i]<<endl;
	}

	cout<<((m_first[m-1]+d-1)%7 == 0? 7:(m_first[m-1]+d-1)%7)<<endl;

	cout<<"星期一\t星期二\t星期三\t星期四\t星期五\t星期六\t星期日\n";



	for(int i=m_first[m-1]-1; i>0;i--)
		cout<<"\t";

	int j=1;
	for(int i=m_first[m-1]-1; j<=many[m-1]; i--){
		
		cout<<j++<<"\t";
		if (!((j+m_first[m-1]-2)%7))
		{
			cout<<endl;
		}
	}
}