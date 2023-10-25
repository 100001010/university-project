// 11360465-田咏帟-
#include <iostream>
#include <cmath>
#include <ctime>
using namespace std;
int main()
{
    while (1)
    {
        cout << "please input a integer,<10" << endl;
        int a = 0;
        cin >> a;
        int ans[10] = {};
        for (int i = 0; i < a; i++)
        {
            int t = rand() % 100 + 1;
            cout << t << " ";
            ans[i] = t;
        }
        cout << endl;

        sort(ans, ans + 10);
        for (int i = 0; i < a; i++)
            cout << ans[10 - a + i] << " ";
        cout << endl;
    }
}