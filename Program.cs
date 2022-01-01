using System;
namespace methodoverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parameters
            string number1= "999" ;
            bool result = int.TryParse ( number1, out int outnumber) ;
            if(result)
                {
                    Console.WriteLine( "success") ;
                    Console.WriteLine( outnumber) ;
       }
       else {
           Console.WriteLine("failed");
       }
               methods instance = new methods () ;
               instance.Sum(4,5, out int sumresult) ;
               Console.WriteLine(sumresult) ;
               // method overloading
               int _statement = 999 ;
               instance.writeonscreen(Convert.ToString(_statement)) ;
               instance.writeonscreen (_statement) ;
               instance.writeonscreen("baris","demirkap") ;

               //Method signiture
               // TheNameofTheMethod + number of parameters + parameters


       } 
       }
       class methods
       {
           public void Sum(int a, int b, out int sum)
           {
               sum= a+b ;
           }
           public void writeonscreen (string data)
           {
               Console.WriteLine(data) ;
           }
           public void writeonscreen (int data)
           {
               Console.WriteLine(data) ;
           }
           public void writeonscreen (string data, string data2)
           {
               Console.WriteLine(data+data2) ;
           }
       }
            }
