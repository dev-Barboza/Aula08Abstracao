using System;

class Cartao : Pagamento
{
 public string token { get; set; }

 public string bandeira { get; set; }

 public int numero { get; set; }

 public string titular { get; set; }

 public int cvv { get; set; }

 //metodo

 protected bool validarToken()
 {
            if (token != null)
        {
            return true;
        }
            return false;
     }
}