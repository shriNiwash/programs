#include<stdio.h>
#include<conio.h>
void sum();
void main()
{
sum();
}
void sum()
{
int a[10],sum=0,i;
printf("\n enter the numbers :");
for(i=0;i<10;i++)
{
scanf("%d",&a[i]);
sum=sum+a[i];
}
printf("\n the sum of integers is : %d",sum);
getch();
}