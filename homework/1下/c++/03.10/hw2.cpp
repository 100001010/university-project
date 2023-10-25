//11360465_田咏帟_hw2
#include<iostream>
using namespace std;

int main(){
    int i1,i2;
    int *p1=&i1,*p2=&i2;
    cin>> *p1>>*p2;
    *p1=*p2+*p1;
    cout<<*p1;
}