//11360465_田咏帟_hw1
#include<iostream>
using namespace std;
int *min(int *p1,int *p2,int *p3){
    int ans;
    int *pans=&ans;
    ans=min({*p1,*p2,*p3});
    return pans;

}
int main(){
    int i1,i2,i3;
    int *p1=&i1,*p2=&i2,*p3=&i3;
    cin>> *p1>>*p2>>*p3;
    cout<<*min(p1,p2,p3);
}