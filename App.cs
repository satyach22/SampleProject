using System;
class App{
int x=23,y=25;
static int p=33,q=44;
const int a1=78;
readonly int b=9;
void add(){
int c=34;
Console.WriteLine(c);

}
static void Main(String[] args){
App a=new App();
a.show();
a.add();
}
void show(){
p=44;
Console.WriteLine(p);
App a=new App();
x=99;
Console.WriteLine(x);
}
}