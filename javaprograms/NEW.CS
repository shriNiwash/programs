#include<stdio.h>
#include<conio.h>
struct student
{
int roll;
char name;
};
void main()
{
struct student s;
 FILE *p;
printf("\nEnter the roll");
scanf("%d",&s.roll);
printf("\Enter the name:");
scanf("%s",s.name);
p=fopen("data.txt","w");
fprintf(p,"%d%s",&s.roll,s.name);
fclose(p);
getch();
}