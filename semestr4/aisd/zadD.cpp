#include<iostream>
#include<limits.h>
#include<vector>
#include<algorithm>

using namespace std;
int mediana(int t[]){
  int min1=t[0], min2=INT_MAX, min3=INT_MAX, ti;
  for(int i=1;i<5;i++){
    ti=t[i];
    if(ti<min3){
      min3=ti;
      if(ti<min2){
        min3=min2;
        min2=ti;
        if(ti<min1){
          min2=min1;
          min1=ti;
        }
      }
    }
  }
  return min3;
}
int MagicznePiatki(int v[],int k,int n){
  if(n<20){
    vector<int> pom;
    pom.resize(n);
    for(int i=0;i<n;i++) pom[i]=v[i];
    sort(pom.begin(), pom.end());
    int wyn=pom[k-1];
    pom.clear();
    return wyn;
  }
  vector<int>M;
  if(n%5==0) M.reserve(n/5);
  else M.reserve(n/5+1);
  vector<int> P;
  P.resize(5, INT_MAX);
  for(int i=0; i<n; i+=5){
    for(int j=0;j<5;j++){
      if(i+j>=n) continue;
      P[j]=v[i+j];
    }
    M.push_back(mediana(&P[0]));
    P.resize(5, INT_MAX);
  }

  P.clear();
  int m=MagicznePiatki(&M[0], M.size()/2,M.size());
  vector<int> Am, Ar, Aw;
  for(int i=0; i<n;i++){
    if(v[i]<m){
      Am.push_back(v[i]);
    }
    else if(v[i]==m){
      Ar.push_back(v[i]);
    }
    else{
      Aw.push_back(v[i]);
    }
  }
  if(Am.size()>=k){
    Aw.clear();
    Ar.clear();
    return MagicznePiatki(&Am[0], k, Am.size());
  }
  if(Am.size()+Ar.size()>=k){
      Aw.clear();
      Am.clear();
      Ar.clear();
    return m;
  }
  return MagicznePiatki(&Aw[0], k-Am.size()-Ar.size(), Aw.size());
}

int main(){
  std::ios::sync_with_stdio(false);
  cin.tie(NULL);
  int n, k, a;
  cin>>n>>k;
  vector<int> V;
  V.reserve(n);
  for (int i = 0; i < n; i++) {
    cin>>a;
    V.push_back(a);
  }
  cout<<MagicznePiatki(&V[0], k, n);
  return 0;
}
