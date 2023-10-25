#include<iostream>
#include<ctime>
#include<cmath>
using namespace std;
int main(){
    bool check;
    srand(time(NULL));
    while(1){
        cout<<"1:執行，0:不執行\n";
        cin>>check;if(check!=1) break;

        int card[4][13]={},point[5]={};

        for(int people=1;people<=4;people++){
            for(int num=0;num<13;num++){
                while(1){
                    
                    int p1=(rand()%4),p2=(rand()%13);
                    if(card[p1][p2]==0){
                        card[p1][p2]=people;
                        
                        if(p2==0)
                            point[people]+=4;
                        if(p2>9)
                            point[people]+=p2-9;
                        break;
                    }
                }       
            }
        }    
        for(int people=1;people<=4;people++){
            cout<<"play"<<people<<":{";
            for(int num=0;num<13;num++)
                if(card[0][num]==people)
                    cout<<"S"<<num+1<<",";
            for(int num=0;num<13;num++)
                if(card[1][num]==people)
                    cout<<"H"<<num+1<<",";
            for(int num=0;num<13;num++)
                if(card[2][num]==people)
                    cout<<"D"<<num+1<<",";
            for(int num=0;num<13;num++)
                if(card[3][num]==people)
                    cout<<"C"<<num+1<<",";
            cout<<" },獲得"<<point[people]<<"點\n1";

        }

    }
}