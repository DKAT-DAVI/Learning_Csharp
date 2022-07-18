using System;

public class Aluno
{
    public String Nome { get; set;}
    //Construtor padrão
    public Aluno()
    {
        //Declarando construtor padrão como "Sem nome definido"
        Nome = "Sem nome definido";
    }

    //Construtor sobrecarregado.
    public Aluno(String nome)
    {
        Nome = nome;
    }
}
