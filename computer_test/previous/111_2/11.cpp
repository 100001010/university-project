#include<iostream>
using namespace std;
int main(){
    int a,b;
    while(cout<<"請輸入兩個數",cin>>a>>b){
        for(;a*a<b;a++)
            cout<<a*a<<",";
        cout<<endl;
    }
}