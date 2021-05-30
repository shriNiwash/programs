#include<stdio.h>
#include<conio.h>
void main()
{
int i,j,num[10],n,a;
clrscr();
printf("\n enter the number :");
scanf("%d",&n);
for(i=0;i<n;i++)
{
printf("\n enter the numbers:");
scanf("%d",&num[i]);
}
for(i=0;i<n;i++)
{
for(j=i+1;j<n;j++)
{
if(num[i]>num[j])
{
a=num[i];
num[i]=num[j];
num[j]=a;
}
}
}
printf("\n the number arranged in assending order:");
for(i=0;i<n;i++)
{
printf("\n%d",num[i]);
}
getch();
}