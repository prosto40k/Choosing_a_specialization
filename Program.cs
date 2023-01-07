//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

void Print (string[] a)
{
  for (int i = 0; i < a.Length; i++)
  {
      System.Console.Write($"[{a[i]+"]"+" ,"}");
  }
  
}

void PrintChange (string[] a,int size=5)
{
  int i=0;
  int w =-1;
  int f =new Random().Next(1,3);
  while (i<=f)
  {
    int q=new Random().Next(0,size-1);
    if (w!=q)
    {
      System.Console.Write($"[{a[q]+"]"+" ,"}");
      i++;
    }
    w=q;
  }
}

int N=5;
//string[] t=new string[N];
string[] t;//не присвоенное (null)
t=new string[N];//создаем массив, то есть в t помещаем адрес массива
string a ="asdfg";
string b ="qwert";
string c ="zxcvb";
string d ="';lk'";
string e ="/.,mn";
t[0]=a;
t[1]=b;
t[2]=c;
t[3]=d;
t[4]=e;

Print(t);
System.Console.WriteLine();
PrintChange(t);

