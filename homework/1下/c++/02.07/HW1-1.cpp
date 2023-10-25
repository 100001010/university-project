// 11360465-田咏帟-1
#include <iostream>
using namespace std;
int main()
{
    while (1)
    {
        cout << "please input string ";
        char a;
        int ans[26] = {};

        while (cin >> a, a != '0')
        {
            ans[int(a - 'a')]++;
        }

        for (int i = 0; i < 26; i++)
        {
            if (ans[i] != 0)
                cout << char(i + 'a') << ":" << ans[i] << endl;
        }
    }
}