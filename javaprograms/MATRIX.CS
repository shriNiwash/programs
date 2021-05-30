#include<stdio.h>
#include<conio.h>
void main()
{
int a[3][2],b[3][2],c[3][2],i,j;
clrscr();
printf("\n enter the fisrt matrix:");
for(i=0;i<3;i++)
{
for(j=0;j<2;j++)
{
printf("\n enter a %d%d",i+1);
scanf("%d",&a[i][j]);
}
printf("\n");
}
printf("\n enter the second matrix:");
for(i=0;i<3;i++)
{
for(j=0;j<2;j++)
{
printf("\n enter b %d%d",i+1);
scanf("%d\n\n",&b[i][j]);
}
printf("\n");
}
for(i=0;i<3;i++)
{
for(j=0;j<2;j++)
{
c[i][j]=a[i][j]+b[i][j];
}
}
printf("\n the sum of matrix\n\n");
for(i=0;i<3;i++)
{
for(j=0;j<2;j++)
{
printf("%d\t",c[i][j]);
}
printf("\n");
}
getch();
}