#include <iostream>
#include <stack>
#include <vector>
using namespace std;
int main()
{
    stack<int> s;
    vector<int> v = {4, 5};
    cout << s.empty()<<endl;

    for (int i = 0; i < 10; i++)
        s.push(i);

    stack<int, vector<int>> s1(v);

    cout << s.top()<<endl;
    cout << s1.top()<<endl;
    s.pop();
    cout << s.top()<<endl;
}