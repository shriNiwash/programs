#include<stdio.h>
#include<conio.h>
void main()
{
int a,b,c;
clrscr();
printf("\n enter the numbers : ");
scanf("%d%d%d",&a,&b,&c);
if(a>b&&a>c)
{
printf("\n gratest number is %d",a);
}
if(b>a&&b>c)
{
printf("\n gratest number is %d",b);
}
else
printf("\n gratest number is %d",c);
getch();
}