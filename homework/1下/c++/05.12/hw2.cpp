//11360465_田咏帟＿hw2
#include <iostream>
#include <cstdlib>
using namespace std;
class Caaa
{
 public:
 Caaa();
 ~Caaa();
};
Caaa::Caaa(){
    cout<<"constructor called"<<endl;
    
 }
Caaa::~Caaa(){
    cout<<"destructor called"<<endl;
    
 }
 // 試在此處撰寫建構元與解構元的程式3碼
int main(void)
{
 Caaa obj; // 建立 obj 物件
 //system("pause");
 return 0;
}