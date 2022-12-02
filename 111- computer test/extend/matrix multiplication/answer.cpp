#include<bits/stdc++.h>
using namespace std;
int main()
{
	int size;
	cin>>size;
	int matrix[2][size][size];

	for (int i=0; i<2; ++i){
		for (int j=0; j<size; ++j){
			for (int k=0; k<size; ++k){
				cin>>matrix[i][j][k];
			}
		}
	}//input two matrix

	for(int i=0; i<size; i++){
		for(int j=0; j<size; j++){
			int total=0;
			for(int k=0; k<size; k++)
				total+=matrix[0][i][k]*matrix[1][k][j];
			cout<<"\t"<<total;
		}
		cout<<endl;
	}
	return 0;
}