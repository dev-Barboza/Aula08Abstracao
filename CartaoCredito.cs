using System;

class CartaoCredito : Cartao
{
   public float limite { get; set; }


   //metodos

   public void AumentarLimite(float acrescimo) ///void. neste caso nao armazenara nada , pois só ira exibir
   {
       limite = limite + acrescimo;
   }
}