#include<iostream.h>
#include<conio.h>
#include<iomanip.h>
inline int sum(int a,int b)
{
return(a+b);
}
void main()
{
int k,l;
clrscr();
cout<<"enter the two numbers:"<<endl
;
cin>>k>>l;
cout<<setw(30)<<"the sum is:"<<sum(k,l)<<endl;
cout<<setw(25)<<"the sum is:"<<sum(k,l);
getch();
}