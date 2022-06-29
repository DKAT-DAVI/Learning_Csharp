using System;

public class Aluno
{
    //Atributo Nome readOnly.
    //Só recebe valor através do construtor.
    public string Nome { get; }

    //Atributo Idade get e set.
    public Int32 Idade { get; set; }

    //Construtor padrão.
    public Aluno() 
    {
        Nome = "Sem nome definido";
        Idade = 0;
    }

    //Construtor sobrecarregado com dois parâmetros.
    public Aluno(string nome, Int32 idade) {
        Nome = nome;
        Idade = idade;
    }   
}
