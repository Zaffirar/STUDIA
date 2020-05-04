#include <iostream>
#define inf 36854775807
using namespace std;
pair<int, int> monety[100];
long long dpmin[1000001], dpmax[1000001];
int tracemin[1000001], tracemax[1000001];
int main()
{
	std::ios::sync_with_stdio(false);
	cin.tie(NULL);
	int f, c;
	cin >> f >> c;
	
	int a, b;
	for (int i = 0; i < c; i++) {
		cin >> a >> b;
		monety[i] = make_pair(a, b);
	}
	for (int i = 1; i <= f; i++)
	{
		dpmin[i] = inf;
		dpmax[i] = -inf;
	}
	dpmin[0] = 0;
	dpmax[0] = 0;
	for (int i = 0; i < f; i++) {
		for (int j = 0; j < c; j++) {
			int pom = i + monety[j].second;
			if (pom > f) continue;
			if (dpmin[pom] > dpmin[i] + monety[j].first)
			{
				dpmin[pom] = dpmin[i] + monety[j].first;
				tracemin[pom] = j;
			}
			if (dpmax[pom] < dpmax[i] + monety[j].first)
			{
				dpmax[pom] = dpmax[i] + monety[j].first;
				tracemax[pom] = j;
			}
		}
	}		
	if (dpmin[f] == inf) {
		cout << "NIE";
		return 0;
	}
	cout << "TAK\n";
	int wyn[100], aktualne=f;
	for (int i = 0; i < c; i++) { 
		wyn[i] = 0;
	}
	while (aktualne != 0) {
		wyn[tracemin[aktualne]]++;
		aktualne -= monety[tracemin[aktualne]].second;
	}
	aktualne = f;
	cout << dpmin[f] << "\n";
	for (int i = 0; i < c; i++) {
		cout << wyn[i] << " ";
		wyn[i] = 0;
	}
	cout << "\n";
	while (aktualne != 0) {
		wyn[tracemax[aktualne]]++;
		aktualne -= monety[tracemax[aktualne]].second;
	}
	cout << dpmax[f] << "\n";
	for (int i = 0; i < c; i++) {
		cout << wyn[i] << " ";	
	}
	return 0;
}
