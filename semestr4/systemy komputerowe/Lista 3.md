# Lista 3
###### tags: `systemy komputerowe`
### zad1
1. 0x100 
2. 0x110
3. 0xAB :arrow_left: 
4. 0xFF :arrow_left: 
5. 0xAB :arrow_left: 
6. adres: 0x100 + 3 + 23 = 0x100 + 0x18 
        6.1. wynik 0x11 :arrow_left: 
7. adres: 0x104 + 0xC (4*3) = 0x110
    7.1. wynik: 0x13 :arrow_left: 
8. adres: 0x100 + 0x18 (8*3) = 0x118
    8.1. wynik: 0x11 :arrow_left:
9. adres: 0x1 + 0x6 + 0x109 (16^2^ + 9 = 265) = 0x110
    9.1. wynik: 0x13 :arrow_left: 
### zad2
| Nr  | Adres       | Wartość     |
| --- | ----------- | ----------- |
| 1.  | 0x100       | 0x100       |
| 2.  | %rdx        | -0x10       |
| 3.  | %rax        | 0x10        |
| 4.  | 0x110       | 0x14        |
| 5.  | %rcx        | 0x0         |
| 6.  | %rdx i %rax | 0xAB i 0x00 |
| 7.  | %rdx        | 0x10        |
| 8.  | %rdx        | 0x16        |

### zad3
1. movl 32 do 64
2. movw 64 do 16
3. movb 8 do 8
4. movb 64 do 8
5. movq 64 to 64
6. movw 16 to 64 

### zad4
1. używamy 32 bitowego adresu na 64 bitowej architekturze
2. %rax ma 64 bity a movl do 32 bitów
3. nie ma przenoszenia z pamięci do pamięci
4. nie ma %sl
5. próba przeniesienia do stałej
6. zła operacja do przenoszenia 32 bit do 64 bit
7. %si to 16 bitów movb jest dla 8 bitów

### zad5

1. x + 6
2. x + y
3. x + 4y
4. 9x + 7
5. 4y + 10
6. x + 2y + 9

### zad6

```
negq %rsi
addq %rsi ,%rdi
negq %rsi
```

### zad7
```
uint64_t compute(int64_t x, int64_t y){
    t = x+y;
    z=t;
    z=z>>31;
    t = z^t;
    t = t-z;
    return t;
}
```
wynikiem jest |x+y| dla -2^32^<x+y<2^32^
