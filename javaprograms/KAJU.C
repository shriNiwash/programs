#include<stdio.h>
#include<conio.h>
struct employee
{
char name[20];
char ad[25];
int sal;
int age;
};
void main()
{
struct employee s[100];
int i,avg,sal,n;
printf("enter the number of student");
scanf("%d",&n);
printf("enter the data of the student");
for(i=0;i<n;i++)
{
printf("enter the name,address,salary,age of the student");
scanf("%s%s%d%d",s[i].name,s[i].ad,&s[i].sal,&s[i].age);
}
for(i=0;i<n;i++)
{
avg=sal/n;
printf("%d\n",avg);
getch();
}