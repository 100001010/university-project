// 11360465-田咏帟-2
#include <iostream>
using namespace std;
int f(int a)
{
    if (a == 1)
        return 1;
    else
        return a * f(a - 1);
}
int main()
{
    while (1)
    {
        cout << "please input a integer" << endl;
        int a, total = 0;
        cin >> a;

        for (int i = 1; i <= a; i++)
            total += f(i);

        cout << "1!+...+" << a << "!=" << total << endl;
    }
}