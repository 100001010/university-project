// 11360465-田咏帟-3
#include <iostream>
#include <random>
#include <ctime>
using namespace std;
int main()
{
    srand(time(NULL));
    while (1)
    {
        cout << "please input a integer" << endl;
        int a;
        cin >> a;
        double ans[10] = {};
        for (int i = 0; i < a; i++)
        {
            int t = 0;
            t = (rand() % 10 + 1);
            cout << t << " ";
            ans[t - 1]++;
        }
        cout << endl;
        for (int i = 0; i < 10; i++)
            cout << i + 1 << "點有" << ans[i] << "次，機率是" << ans[i] / a << "%" << endl;
    }
}