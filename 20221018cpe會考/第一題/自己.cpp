#include <iostream>
using namespace std;
int main()
{
	int inp;
	while(cin>>inp){
		do
		{
			int total=0;
			while(inp){
				total=total+inp%10;
				inp/=10;
			}
			if(total/10)	inp=total;
			else	cout<<total;
		} while (inp>=10);
	}
	return 0;
}