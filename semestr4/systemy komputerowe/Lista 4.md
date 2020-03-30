# Lista 4
###### tags: `systemy komputerowe`
### Zad1
```
cmp  %reg1, %reg2
setl %reg3
```
setl zapala ostati bit %reg3, jeżeli %reg2 jest mniejsze od %reg1; setl wykonuje opereraję na flagach SF^OF
>Dla uproszczenia %reg1 nazwijmy "b", %reg2 "a", a %reg2 - %reg1 "t"
1. SF=1, OF=1, SF^OF=0, więc:
    >(t<0) && (a>0 && b<0 && t<0) || (a<0 && b>0 && t>0), z rachunku zdań:
    >(a>0 && b<0 && t<0) :arrow_right: a>b :arrow_right: %reg2>%reg1 :ok:
2. SF=1, OF=0, SF^OF=1:
    > (t<0)&&~((a>0 && b<0 && t<0) || (a<0 && b>0 && t>0))
    > (t<0)&&(~(a>0 && b<0 && t<0)&&~(a<0 && b>0 && t>0))
    > (t<0)&&((a<0 || b>0 || t>0)&&(a>0 || b<0 || t<0))
    > (a<0 || b>0) && (t<0)
    > 2.1. a<0 && t<0
        >>a<b :arrow_right: %reg2<%reg1 :ok:
        >> 
    > 2.2. b>0 && t<0
        >>b>a :arrow_right: %reg1>%reg2 :ok:
3. SF=0, OF=1, SF^OF=1:
    >(t>0)&&((a>0 && b<0 && t<0) || (a<0 && b>0 && t>0))
    > a<0 && b>0 && t>0
    > a<b :arrow_right: %reg2<%reg1 :ok:
4. SF=0, OF=0, SF^OF=0:
    > (t>0)&&~((a>0 && b<0 && t<0) || (a<0 && b>0 && t>0))
    > (t>0)&&(~(a>0 && b<0 && t<0)&&~(a<0 && b>0 && t>0))
    > (t>0)&&((a<0 || b>0 || t>0)&&(a>0 || b<0 || t<0))
    > (t>0)&&(a>0||b<0)
    > 4.1. a>0 && t>0
    >> a>b :arrow_right: %reg2>%reg1 :ok:
    >> 
    >4.2. b<0 && t>0
    >> a>b :arrow_right: %reg2>%reg1 :ok:
---
```
cmp  %reg1, %reg2
setb %reg3
```
setb zapala ostatni bit %reg3 jeżeli %reg2<%reg1; setb sprawdza flagę CF:
![](https://i.imgur.com/X2tu6Lr.png)
:ok:
### Zad 2
```c=
void who(int16_t v[], size_t n){
    n--;
    for(size_t i=0;i<n;i++){
        short a = v[i];
        short b = v[n];
        v[i] = b;
        v[n] = a;
        n--;
    } 
    
}
```
![](https://i.imgur.com/ToLiI1r.png)

Efekt: odwrócenie tablicy v;
### Zad 3
```c=
#include "stdbool.h"

bool zonk(char* a, char* b)
{
    int i=0;
    for(;(a[i]!=0);i++){
        if(b[i]!=a[i])
            return 0;
    }
    return !(a[i]|b[i]);
}
```
![](https://i.imgur.com/HgxFCfx.png)

### Zad 4 
1. pushq %reg1
```
sub $8, %rsp
movq %reg1, (%rsp)
```
2. popq %reg2
```
movq (%rsp), %reg2
addq $8, %rsp
```

### Zad 6
```c=
#include "stdint.h"

uint32_t rec(uint32_t n){
    if(n==0)
        return 1;
    return n*rec(n-1);
}
```
![](https://i.imgur.com/q0fycia.png)
Efekt: silnia


