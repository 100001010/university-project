#include <iostream>
#include <queue>
using namespace std;
int main()
{
    queue<int> q;

    cout << q.empty() << endl; // 1 or ture

    for (int i = 0; i < 10; i++)
        q.push(i); //{0,1,2,3,4~9}

    cout << q.front() << endl; // 0
    q.pop();                   //{1,2,3~9}
    cout << q.back() << endl;  // 9

    cout << q.empty() << endl; // 0

    cout << q.size() << endl;

    
}