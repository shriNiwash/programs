#include<stdio.h>
#include<conio.h>
void sum();
void main()
{
sum();
}
void sum()
{
int sum=0,a[10],i;
printf("\n enter the 10 number as you like:");
for(i=0;i<10;i++)
{
scanf("%d",&a[i]);
sum=sum+a[i];
}
for(i=0;i<10;i++)
{
printf("\n the numers you entered %d\n",a[i]);
}
printf("\n the total sum is %d",sum);
getch();
}
