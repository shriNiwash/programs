#include<iostream.h>
#include<conio.h>
float circle(float a)
{
float y;
y=3.14*a*a;
return y;
}
int rec(int b,int c)
{
int k;
k=b*c;
return k;
}
void main()
{
float r,l,h;
clrscr();
cout<<"enter the radius:";
cin>>r;
cout<<"enter the lenght and base:";
cin>>l>>h;
cout<<"the area of circle is:"<<circle(r)<<endl;
cout<<"the area of reactangle is:"<<rec(l,h);
getch();
}