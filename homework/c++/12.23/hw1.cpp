//11360465-田咏帟-hw1
#include<iostream>
#include<ctime>
#include<cstdlib>
using namespace std;
int main(){
    int n;

    while(cin>>n){
        srand(time(NULL));
        int a[7]={};
        for(int i=0;i<n;i++)
            a[rand()%6+1]++;
        for(int i=1;i<=6;i++)
            cout<<i<<"點:"<<a[i]<<"次，機率為"<<a[i]*100/n<<"%"<<endl;  
    }
}