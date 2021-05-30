#include<stdio.h>
#include<conio.h>
void main()
{
int n,m;
clrscr();
printf("\n enter the number:");
scanf("%d",&n);
m=n%2;
{
if(m==0)
printf("even");
else printf("odd");
}
getch();
}
