#include<bits/stdc++.h>
using namespace std;
int main(){
	char a;

	while(1){
		int p[26]={};
		while(cin>>a,a!='0'){
			p[a-97]+=1;
		}
		char temp='a';
		for(int i=0;i<26;i++)
			cout<<temp++<<" "<<p[i]<<endl;
	}

}