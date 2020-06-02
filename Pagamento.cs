using System;

class Pagamento
{

    //atributos
    public DateTime data { get; set; }

    public float valor { get; set; }

    //metodos

    public string pagar(float valorPago)
    {
        return "o valor pago é de " + valorPago + "reais";
    }

    public string cancelar()
    {
        return "cancelado !";
    }

}