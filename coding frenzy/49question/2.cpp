#include<iostream>
#include<string>
using namespace std;

int main(){
	string a;
	int n;cin>>n;
	getline(cin,a);
	for(int k=0;k<n;k++){
		getline(cin,a);
		bool ans=1;
		string l,r;
		
		for(int i=0;i<a.size();i++)
			if(a[i]=='('||a[i]=='[')
				l+=a[i];
			else if(a[i]==')'||a[i]==']') 
				r+=a[i];
			else
				continue;
		
		if(l.size()!=r.size()){
			cout<<"No"<<endl;
			continue;			
		}

		for(int i=0;i<l.size();i++)
			if(l[i]=='('&&r[i]!=')')
				ans=0;
			else if(l[i]=='['&&r[i]!=']') 
				ans=0;
		
		if(ans)
			cout<<"Yes";
		else
			cout<<"No"; 
	}
	
}
