#include<iostream>
#include<vector>
#include <algorithm>
using namespace std;
int main(){
    freopen("input.txt","r",stdin);
    freopen("output.txt","w",stdout);
    int a;
    vector<int> v;
    for(int i=0;cin>>a;i++){
        v.push_back(a);
        sort(v.begin(),v.end());
        if(i%2==1)
            cout<<(v[i/2]+v[i/2+1])/2<<endl;
        else 
            cout<<v[i/2]<<endl;
    }

}
