#include<iostream>
#include<string>
using namespace std;
int main(){
    #ifdef fre
        freopen("in.txt","r",stdin);
        freopen("out.txt","w",stdout);
    #endif
    string s;
    while(getline(cin,s)){
        int ascii[129]={};
        for(char i:s){
            ascii[int(i)]++;
        }
        for(int i=1;i<1000;i++){
            for(int j=129;j>0;j--)
            if(ascii[j]==i){
                cout<<j<<" "<<i<<endl;
            }
        }
        cout<<endl;
    }
}