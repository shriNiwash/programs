#include<stdio.h>
#include<conio.h>
struct student
{
int roll;
char name[20];
float salary;
};
struct student s[100];
int i,n,avg,total=0;
printf("enter the number");
scanf("%d",&n);
for(i=1;i<=n;i++)
{
printf("enter your roll,name,salary of the student");
scanf("%d%s%f",&s[i].roll,s[i].name,&s[i].salary);
total=salary+s[i].salary;
}
for(i=0;i<n;i++)
{
printf("\nyour roll no is %d",s[i].roll);
printf("\nyour name is %s",s[i].name);
printf("\n your salary is %f",s[i].salary);
}
avg=total/n;
printf("\n your average salary is %f",avg);
getch();
}