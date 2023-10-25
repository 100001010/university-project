#include <iostream>
#include <cstdlib>
using namespace std;
class CTime
{
 private:
    int hour,min;
    double sec;
 public:
    CTime(int h,int m,double s):hour(h),min(m),sec(s){}
    CTime(){}
    void show_time()
    {
        cout << hour << "hr " << min << "min " << sec <<
                "sec" << endl;
    }
    void set_time(int h,int m,double s){
        hour=h;min=m;sec=s;

    }
};
int main(void)
{
 CTime t1(4,23,56.3);
 CTime t2(5,45,30.3);
 CTime t3;
 t1.show_time();
 t2.show_time();
 system("pause");
 return 0;
}