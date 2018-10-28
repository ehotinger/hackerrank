#include <stdio.h>

void update(int *a,int *b) {
    // Complete this function
  int x; int t=*a;
    *a=*a+*b;
   x=t-(*b);
  if(x<0)
  { x=x*(-1);
    *b=x;
  }
    else *b=x;
   
}

int main() {
    int a, b;
    int *pa = &a, *pb = &b;
    
    scanf("%d %d", &a, &b);
    update(pa, pb);
    printf("%d\n%d", a, b);

    return 0;
}
