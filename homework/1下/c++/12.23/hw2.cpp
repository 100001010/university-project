//11360465-田咏帟-hw2
#include<iostream>
using namespace std;
int main(){
    int a,b;
    while(cout<<"請輸入兩個整數"<<endl,cin>>a>>b){
        int bo=0,n=0;
        while(a>0||b>0){
            bo=(a%10+b%10+bo)/10;
            if(bo) n++;
            a/=10;  b/=10;
        }
        cout<<"總共進位"<<n<<"次"<<endl;
    }
}