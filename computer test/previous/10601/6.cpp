#include<bits/stdc++.h>
using namespace std;
int main(){
	string a;

	while(getline(cin,a)){
		for (int i = 0; i < a.length(); ++i)
		{
			if(a[i]<97)a[i]=a[i]+32;
			else	   a[i]=a[i]-32;

		}
		cout<<a<<endl;
	}

}