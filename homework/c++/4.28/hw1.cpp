//11360465_田咏帟＿hw1
#include<iostream>
using namespace std;
class Watch{
    private:
        int h,m,s;
    public:
        Watch(int h,int m,int s){
            this->h=h;this->m=m;this->s=s;
        }
        Watch(){
            this->h=0;this->m=0;this->s=0;
        }
        void print(){
            cout<<h<<":"<<m<<":"<<s<<endl;
        }
        void input(){
            cin>>h>>m>>s;
        }
        void go(int s){
            this->s+=s;
            if(this->s>=60){
                this->s-=60;
                if(m>=60){
                    m-=60;
                    h++;
                    if(h>24){
                        h-=24;
                    }
                }
                   

            }
                

        }

};
int main(){
    while(1){
        Watch w1,w2(10,59,30);
        w1.print();
        w2.print();
        w1.input();
        w1.go(55);
        w1.print();
    }
}