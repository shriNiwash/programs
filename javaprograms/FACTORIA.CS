#include<stdio.h>
#include<conio.h>
struct employee
{
char name[20];
int id;
float salary;
};
void main()
{
int i,n;
clrscr();
struct employee emp[100];
int salary=0;
printf("enter the number how many you want to add:");
scanf("%d",&n);
for(i=0;i<n;i++)
{
printf("\nenter the name of employee:");
scanf("%s",emp[i].name);
printf("\n enter the id of employee:");
scanf("%d",&emp[i].id);
printf("\n enter the salary of employee:");
scanf("%f",&emp[i].salary);

}
printf("total salary is %d",&salary);
getch();
}


















