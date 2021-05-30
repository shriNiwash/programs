#include<stdio.h>
#include<conio.h>
int fib(int);
void main()
{
int i,n,no;
clrscr();
printf("\n enter the number :");
scanf("%d",&n);
for(i=1;i<=n;i++)
{
no=fib(i);
printf("%d\t",no);
}
getch();
}
int fib(int x)
{
if(x==0 || x==1)
return 1;
else
return(fib(x-1)+fib(x-2));
}