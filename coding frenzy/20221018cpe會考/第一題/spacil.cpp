#include <iostream>
using namespace std;
int main()
{
	int n ; while(cin>> n){ 
	n %= 9 ; if(!n) n = 9 ; 
	cout << n << endl ; }
}