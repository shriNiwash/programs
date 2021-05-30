#include<stdio.h>
#include<conio.h>
void main()
{
int i,n,m=1;
clrscr();
printf("\n enter the number :");
scanf("%d",&n);
for(i=n;i>=1;i--)
{
m=m*i;
}
printf("\n the factorial is %d",m);
getch();
}
