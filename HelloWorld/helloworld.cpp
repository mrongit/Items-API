#include<iostream>
using namespace std;
    int main()
{
#ifndef ONLINE_JUDGE
	freopen("input1.txt","r",stdin);
	freopen("output1.txt","w",stdout);
#endif
    int a;
    cin>>a;
    cout<<a<<endl;

    string name;
    cin>>name;
    cout<<"Hi "<<name<<"!! How are you?";
}