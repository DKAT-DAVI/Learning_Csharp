using System;

public class Credencial
{
    //Atributo Identificacao.
    public String Identificacao { get; set; }

    //Atributo Senha.
    //Tem o get privado.
    public String Senha { private get; set; }

    //Atributo Ativo.
    //Informa se o usuário está ativo ou inativo.
    public Boolean Ativo { get; set; }

    //Método Atenticar.
    /*Retorna um booleano verificando
    se a senha digitada está correta.*/
    public Boolean Autenticar(String senha){
       return Senha == senha;
    }

    //Associação com a classe Usuário.
    public Usuario usuario { get; set; }

}
