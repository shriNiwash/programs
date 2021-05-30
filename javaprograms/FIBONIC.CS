#include<stdio.h>
#include<conio.h>
void main()
{
int i,a=1,b=1,c;
clrscr();
printf("%d\t%d\t",a,b);
for(i=1;i<=5;i++)
{
c=a+b;
printf("%d\t",c);
a=b;
b=c;
}
getch();
}
