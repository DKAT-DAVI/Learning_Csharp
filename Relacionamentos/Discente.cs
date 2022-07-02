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

    //Associação à outra classe.
    public Telefone FonePrincipal { get; set; }
    

    //Construtor estático.
    static Discente() {
        //2022 0000
        Serial = DateTime.Now.Year * 10000;
    }

    //Construtor padrão.
    //Invocado cada vez que é criado um novo objeto.
    public Discente()
    {
        /*A cada vez que o construtor
        é invocado, Serial recebe 1 incremento e é armazenado em Matricula*/
        Matricula = ++Serial;
        Nome = "Sem nome definido";
    }

    //Construtor sobrecarregado.
    public Discente(String nome){
        Nome = nome;
    }

    public override string ToString()
    {
        return $"Matrícula: {Matricula}\nNome: {Nome}\nTelefone = {FonePrincipal}";
    }

}
