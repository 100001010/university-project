#include<bits/stdc++.h>
using namespace std;
int main(){
	int n[10];

	while(1){
		int temp=0 ;
		for (int i = 0; i < 10; ++i)
			n[i]=-1;
		while(cin>>n[temp],n[temp]!=-1){
			temp++;
		}
		for (int i = 10; i > 0; --i)
			for (int j = 0; j < i-1; ++j)
				if (n[j]>n[j+1])
					swap(n[j],n[j+1]);
		for (int i = 0; i < 10; ++i)
			if(n[i]==-1)continue;
			else        cout<<n[i]<<" ";
		cout<<endl;	
	}


}