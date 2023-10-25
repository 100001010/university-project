#include <iostream>
using namespace std;

int main() {
	int a, d;
	while(cin >> a >> d) {
		int ans = 0;
		while(a>0||d>0) {
			int c=0;
			c=(a%10+d%10)/10;
			if(c)
				ans++;
			a/=10;
			d/=10;
		}
		cout << ans;
	}
}