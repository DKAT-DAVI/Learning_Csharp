using System;

//Classe faz o cadastro de um produto.
public class Eletrodomestico
{
    /*Atributo Codigo:
    Recebe o código do produto.*/
    public UInt64 Codigo { get; set; }

    /*Atributo Nome:
    Recebe o nome do produto.*/
    public String Nome { get; set; }

    /*Atributo Preco:
    Recebe o preço do produto.*/
    public Decimal Preco { get; set; }

    /*Formatação da exibição, usando o
    método ToString.*/
    public override string ToString()
    {
        return $"Objeto: Eletrodoméstico\nToString();\n{String.Format(@"{0:00-0000-00000-0}", Codigo)}, {Nome}, R${String.Format(@"{0:0,000.00}", Preco)}\n";
    }

}
