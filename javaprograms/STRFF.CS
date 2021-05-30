#include<stdio.h>
#include<conio.h>
struct student
{
int id;
char name[20];
float marks;
};
void func(struct student record);
void main()
{
struct student record;
clrscr();
printf("\n enter the  name:");
scanf("%s",record.name);
printf("\n enter the id");
scanf("%d",&record);
printf("\n marks:");
scanf("%f",&record.marks);
func(record);
}
void func(struct student record)
{
printf("\n id =%d",record.id);
printf("\n name=%s",record.name);
printf("\n narks=%f",record.marks);
getch();
}
