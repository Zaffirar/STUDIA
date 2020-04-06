# Lista 5
###### tags: `systemy komputerowe`
### Zad1
```c++=
#include <iostream> 
using namespace std; 
  
struct test1  
{ 
    short s; 
    int i; 
    char c; 
}; 
   
struct test2  
{ 
    int i; 
    char c; 
    short s; 
}; 
  
int main() 
{ 
    test1 t1; 
    test2 t2; 
    cout << "size of struct test1 is " << sizeof(t1) << "\n"; 
    cout << "size of struct test2 is " << sizeof(t2) << "\n"; 
    return 0; 
} 
```
Wyjście:
```
size of struct test1 is 12
size of struct test2 is 8
```

struct 1:
| s   | s       | padding | padding |
| --- | ------- | ------- | ------- |
| i   | i       | i       | i       |
| c   | padding | padding | padding |
struct 2:
| i   |    i    | i   | i   |
| --- | ------- | --- | --- |
| c   | padding | s   | s   |
### Zad2
| tbl | tbl | tbl | tbl | tbl | tb  | tbl | tbl | tbl | tbl | tmp | padding | secret | secret |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | ------- | ------ | ------ |
| 0    |  1   |  2   |  3   |  4   |  5   |  6   |  7   |  8   |  9   |  10   |   11      |   12     |  13      |
Odp: 6
### Zad3
```c=
#include <stdint.h>

typedef struct {
int32_t x[9][5];
int64_t y;
} str1;
typedef struct {
int8_t array[5];
int32_t t;
int16_t s[9];
int64_t u;
} str2;

void set_val(str1 *p, str2 *q) {
int64_t v1 = q->t;
int64_t v2 = q->u;
p->y = v1 + v2;
}
```
### Zad 5
Semantyka << a ? b : c>>:
```c=
if(a)
{
b
}
else
{
c
}
```
![](https://i.imgur.com/6SglYql.png)
funkcja to dereferencja argumentu lub zero jeżeli argument = NULL
