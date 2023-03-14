#include<string>
#include<stack>
#include<iostream>
using namespace std;

int main(){
    freopen("input.txt","r",stdin);
    freopen("output.txt","w",stdout);
    int n;cin>>n;
    string a;
    getline(cin,a);
    for(int i=0;i<n;i++){
        bool boolen=1;
        stack<char> b;
        getline(cin,a);
        
        for(char t:a){
            if(a.empty())
                break;
            if(t=='('||t=='[')
                b.push(t);
            else{
                if(!b.empty()&&(b.top()+1==t||b.top()+2==t)){
                    b.pop();
                }else{
                    boolen=0;
                    break;
                }
            }
        }
        if(boolen   &&b.empty())
            cout<<"Yes"<<endl;
        else
            cout<<"No"<<endl;
    }
}