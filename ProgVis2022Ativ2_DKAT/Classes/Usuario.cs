using System;
using System.Text;

//Classe que cadastra um usuário.
public class Usuario
{
    //Atributos.
    //Atributo Nome.
    public String Nome { get; set; }
    
    //Atributo Email.
    public String Email { get; set; }

    //Atributo Idade.
    public Byte Idade { get; set; }

    /*Atributo privado _nascimento, recebe um valor
    vindo do atributo público Nascimento.*/
    private DateTime _nascimento {get; set;}

    /*Atributo público Nascimento, recebe a data de
    nascimento, guarda em _nascimento e faz operações
    para descobrir a idade.*/
    public DateTime Nascimento { 
            get{
                return _nascimento;
            }
            set{
                //_nascimento recebe o valor que será inserido em Nascimento.
                _nascimento = value;
                //Idade recebe o ano atual menos o ano de nascimento.
                Idade = Convert.ToByte(DateTime.Now.Year - _nascimento.Year);
                /*Se o aniversário ainda não tiver acontecido,
                diminui 1 ano da idade.*/
                if (DateTime.Now.DayOfYear < _nascimento.DayOfYear)
                {
                    Idade -= 1;
                }
            }
        }

    //Associação com a classe Credencial.
    public Credencial credencial { get; set; }

    //Formatação para a exibição usando o ToString
    public override string ToString()
    {
        return $"** Usuário **\nNome = {Nome}\nEmail = {Email}\nNascimento = {_nascimento.ToString("dd/MM/yyyy")}\nIdade: {Idade}\n** Credencial **\nIdentificação = {credencial.Identificacao}\n{(credencial.Ativo is true ? "Ativo" : "Inativo")}";
    }

}
