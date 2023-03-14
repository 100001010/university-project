#include<string>
#include<iostream>
using namespace std;
int main(){
    string in,target;
    while(1){
        cout<<"請輸入文章"<<endl;
        getline(cin,target);
        cout<<"請輸入想在文章中找到的字"<<endl;
        getline(cin,in);
        int *kmp= new int [in.size()];
        kmp[0]=0;
        for(int i=1;i<in.size();i++){
            if(in[kmp[i-1]]==in[i]){
                kmp[i]=kmp[i-1]+1;
            }else{
                kmp[i]=0;
            }
            //cout<<kmp[i];
        }
        
        int in_prt=0;
        for(int i=0;i<target.size();i++){
            if(in[in_prt]==target[i]){
                in_prt++;
                if(in_prt==in.size()){
                    in_prt--;
                    cout<<"在"<<i-in_prt+1<<"到"<<i<<"之間為尋找對象"<<endl;
                    i-=kmp[in_prt];
                    in_prt=0;
                    
                }
            }else{
                in_prt=kmp[in_prt-1];
                continue;
            } 
        }
        delete[] kmp;
    }
}

/*
0 1 2 3 4 5 6 7 8 9 
a s d s d a f a s d
0 0 0 0 0 1 0 1 2 3 

a s d a s d a s d
0 0 0 1 2 3 4 5 6 
*/
