#include <iostream>
#include <algorithm>
#include <cmath>
using namespace std;
int main()
{
    int a;
    cin >> a;
    while (cin >> a)
    {

        int c[a], b[a];
        for (int i = 0; i < a; i++)
            cin >> b[i];
        sort(b, (b + a - 1));
        int p = a / 2 + 1;
        int total = 0;
        for (int i = 0; i < a; i++)
            total += abs(b[p] - b[i]);
        cout << total << endl;
    }
}