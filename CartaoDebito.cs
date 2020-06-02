using System;

class CartaoDebito : Cartao
{
    public float saldo { get; set; }

    //metodo

    public string tranferir()
    {
        return " pagaemnto realizado com sucesso";
    }

    public string pagarTitulo()
    {
        return "pagamento realizado";
    }
}