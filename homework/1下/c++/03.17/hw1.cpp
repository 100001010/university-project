//11360465-田咏帟-hw1
#include<iostream>
#include<string>
#include<algorithm>
using namespace std;
int main(){
    string s;
    cin>>s;
    string *p = &s;
    for(char i:*p)
        cout<<char(toupper(i));
    
    

}