using System;

public class Aluno
{
    //Atributo 
    //private String nome;
    private String _nome;
    
    //Método que recebe o nome.
    public void SetNome(string nome)
    {
        //this.nome = nome;
        _nome = nome;
    }

    //Método que retorna a string nome que foi recebido.
    public String GetNome()
    {
        //return this.nome;
        //return nome;
        return _nome;
    }
}
