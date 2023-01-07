//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

void Print (string[] a)
{
  for (int i = 0; i < a.Length; i++)
  {
      System.Console.Write($"[{a[i]+"]"+" "}");
  }
  
}

void PrintChange (string[] a,int size=5)
{
  int i=0;
  int w =-1;
  int f =new Random().Next(1,4);
  int w1=-1;
  int w2=-1;
  while (i<=f)
  {
    int q=new Random().Next(0,size-1);
    w1=q;//1значение,2значениеб,3знач
    if (w1!=w)//1значение-1,2 и 1,3знач и 2знач
    {
      
      if (w1!=w2)//1значение с-1,2 и -1,3знач и 1знач
      {
        w2=w;//=-1,1знач,2знач
        if (w!=q)
      {
        System.Console.Write($"[{a[q]+"]"+" "}");
        i++;
        w=q;//1значение,2знач
      }
      } 
    }
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

