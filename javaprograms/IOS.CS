#include<iostream.h>
#include<conio.h>
void main()
{
int a,b,c;
clrscr();
cout<<"enter the numbers :";
cin>>a>>b>>c;
if(a>b && a>c)
cout<<"the gratest no is:"<<a;
if(b>a && b>c)
cout<<"the gratest no"<<b;
else
cout<<"the gretest no is:"<<c;
getch();
}