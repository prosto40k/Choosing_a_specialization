﻿//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
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

void PrintChange (string[] a)
{
  int i=0;
  int box =-1;
  int size =new Random().Next(0,3);
  int box1=-1;

  while (i<=size)
  {
    int randIndex=new Random().Next(0,a.Length);
    if (randIndex!=box)
    {
      if (randIndex!=box1)
      {
        box1=box;
        System.Console.Write($"[{a[randIndex]+"]"+" "}");
        i++;
        box=randIndex;
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
string e ="mnbvcv";
t[0]=a;
t[1]=b;
t[2]=c;
t[3]=d;
t[4]=e;

Print(t);
System.Console.WriteLine();
PrintChange(t);

