//11360465-田永帟-hw3
#include<iostream>
using namespace std;
double avg(int,int,int);
int main(){
    int a,b,c;
    cin>>a>>b>>c;
    cout<<avg(a,b,c);

    return 0;
}
double avg(int a,int b,int c){
    return (a+b+c)/3.;
}