#include<iostream>
#include<string>
using namespace std;
int main(){
    freopen("input.txt","r",stdin);
    freopen("output.txt","w",stdout);
    string in,a="   1234567890-=qwertyuiop[]\\asdfghjkl;\'zxcvbnm,./";
    while(getline(cin,in)){
        for(char i:in){
            cout<<a[a.rfind(i)-2];
        }
        cout<<endl;
    }

}