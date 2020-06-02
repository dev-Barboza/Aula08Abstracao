using System;

namespace abstracao1
{
    class Program
    {
        static void Main(string[] args)
        {
           CartaoCredito x = new CartaoCredito();
           x.limite = 4500f ; 
          
          Console.WriteLine("Quanto acresentar de limite");
          float acrescimo = float.Parse (Console.ReadLine());

          x.AumentarLimite(acrescimo);
          Console.WriteLine ("novo limite é de " + x.limite);

          
        }
    }
}
