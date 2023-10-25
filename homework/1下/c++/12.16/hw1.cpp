//11360465-田咏帟-wh1
#include<bits/stdc++.h>
using namespace std;
int main(){
	string a;
	cout<<"Please input a string.\n";
	while(getline(cin,a)){
		
		for (int i = 0; i < a.length(); ++i)
		{
			if(a[i]<97)a[i]=a[i]+32;
			else	   a[i]=a[i]-32;

		}
		cout<<a<<endl;
		cout<<"Please input a string.\n";
	}
}