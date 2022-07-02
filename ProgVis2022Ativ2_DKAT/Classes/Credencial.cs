using System;

public class Credencial
{
    public String Identificacao { get; set; }
    public String Senha { set; private get; }
    public Boolean Autenticar(String senha){
       return  Senha == senha;
    }

}
