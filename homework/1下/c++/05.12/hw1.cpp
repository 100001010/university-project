//11360465_田咏帟＿hw1
#include <iostream>
#include <cstdlib>
using namespace std;
class Cwin
{
    private:
        char id;
        int width,height;

    public:
    Cwin(char i,int w,int h):id(i),width(w),height(h)
    {
        cout<<"建構元被呼叫了..."<<endl;
    }
    ~Cwin();
    void show_number(void){
        cout<< "Window" << id << ": ";
        cout<<"width="<<width<<",height="<<height<<endl;
    }
};
 // 試在此處撰寫建構元與解構元的程式碼
 Cwin::~Cwin(){
        cout<<"解構元被呼叫了"<<this -> id<<"被銷毀了.."<<endl;
    }

int main(void)
{
    Cwin win1('A',50,40);
    Cwin win2('B',40,50);
    Cwin win3('C',60,70);
    Cwin win4('D',90,40);

    win1.show_number();
    win2.show_number();


}