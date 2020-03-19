#include <iostream>
using namespace std;

int main() {
	std::ios::sync_with_stdio(false);
	cin.tie(NULL);
	int a, b, t;
	cin>>a;
	cin>>b;
	if(a>b){
		t=a;
		a=b;
		b=t;
	}
	for(int i=a; i<=b; i++){
		cout<<i<<"\n";
	}
}