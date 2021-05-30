#include<stdio.h>
#include<conio.h>
void main()
{
int n;
clrscr();
printf("\n enter the number :");
scanf("%d",&n);
switch(n);
{
case 1:printf("synday");
break;
case2:printf("monday");
break;
case 3:printf("tuesday");
break;
case 4:printf("wednesday");
break;
case 5:printf("thursday");
break;
case 6:printf("friday");
break;
case 7:printf("saturday");
break;
defult:printf("invalid");
}
getch();
}
