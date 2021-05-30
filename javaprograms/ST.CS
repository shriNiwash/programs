#include<stdio.h>
#include<conio.h>
struct student
{
char name[20];
int roll;
int per;
};
void main()
{
struct student st[100];
int i,n;
clrscr();
printf("\n enter the number :");
scanf("%d",&n);
for(i=0;i<n;i++)
{
printf("\ enter the name:");
scanf("%s",st[i].name);
printf("\n enter the roll:");
scanf("%d",&st[i].roll);
printf("\n enter the percentage:");
scanf("%d",&st[i].per);
}
for(i=0;i<n;i++)
{
if(st[i].per>80)
{
printf("\nthe name of student having distiction:%s",st[i].name);
}
}
getch();
}