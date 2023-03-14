#include <iostream>
#include <stack>
#include <string>
using namespace std;
int main()
{
    while(1){
        string str;
    getline(cin, str);
    stack<char> a;
    int b = 1;
    int b1=0;
    for (int i = 0; i < str.size(); i++)
    {
        if (str[i] == '(')
            a.push(str[i]);
        else if (str[i] == '[')
            a.push(str[i]);
        if(a.size()==0){
            b1=0;
            break;
        }
        else if (str[i] == ')')
            if (str[i] == a.top() + 1)
            {
                a.pop();
            }
            else
            {
                b = 0;
            }
        else if (str[i] == ']')
            if (str[i] == a.top() + 2)
            {
                a.pop();
            }
            else
            {
                b = 0;
            }
    }
    if(b1==0){
        cout<<0;
        continue;
    }
    else if(a.size()!=0)
        cout<<0;
    else
        cout<<b;
    }
    
}