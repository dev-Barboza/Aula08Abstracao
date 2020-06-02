using System;

class Boleto : Pagamento
{

    //atributos
    public DateTime dataVencimento { get; set; }

    public string bancoEmissor { get; set; }

    public string  codigoDeBarras { get; set; }

    //metodos

    public string RegistarNoSistema()
    {
        return "Boleto registrado com sucesso";
    }
}