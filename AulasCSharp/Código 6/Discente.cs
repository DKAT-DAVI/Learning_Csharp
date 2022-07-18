using System;


public class Discente
{
    public static Int32 Serial { 
        get; 
        //Definindo set privado; 
        private set; 
    }
    public Int32 Matricula { set ; get; }    
    public String Nome { get; set; }

    //Construtor estático.
    static Discente() {
        Console.WriteLine("Construtor estático invocado.");
        //2022 0000
        Serial = DateTime.Now.Year * 10000;
    }

    //Construtor padrão.
    //Invocado cada vez que é criado um novo objeto.
    public Discente()
    {
        Console.WriteLine("Construtor padrão invocado.");
        /*Serial++;
        Matricula = Serial; */
        /*A cada vez que o construtor
        é invocado, Serial recebe 1 incremento e é armazenado em Matricula*/
        Matricula = ++Serial;
    }

    /*Gera erro pois é um método da classe que está
    tentando imprimir um atributo de um objeto

    public static void TestaAtributoInstancia() {
        Console.WriteLine($"Matrícula: {Matricula}");
    }*/

    /*Método herdado de object, retorna por padrão o
    nome da classe a que o objeto pertence.*/
    /*Pode ser sobreescrito sendo formatado para a exibição.*/
    public override string ToString()
    {
        return $"{Matricula} ->  {Nome}";
    }
}
