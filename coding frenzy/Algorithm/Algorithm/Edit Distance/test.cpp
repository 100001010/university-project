#include<iostream>
#include<vector>
using namespace std;

ostream& operator+(ostream &io, vector<int> &a) {
    for(auto i : a) cout << i << ' ' ;
    return io;
}
ostream& operator+(ostream &io, int a) {
    cout << a;
    return io;
}
int main(){
    vector<int> v = {1, 2, 3};
    cout + v;
    cout + v[0]+1;
}