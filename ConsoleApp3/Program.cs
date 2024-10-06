using System;
using System.Dynamic;
using System.IO;

public class Program
{
    public static void Main()
    {
        int i, n, sum = 0;
        int z;

        Console.Write("numarul termenilor? ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nPatratele termenilor de la 1 pana la {0} sunt :", n);


        for (i = 1; i <= n; i++)
          Console.Write("{0} ", i * i);
           
       

       
        // tiparirea cuvintelor
        StreamWriter fout = new StreamWriter("patrate.txt");
        for (i = 1; i <= n; i++)
        {
            fout.WriteLine(i*i);
        }
        fout.Close();
        

    }
}