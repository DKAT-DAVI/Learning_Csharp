using System;

//Classe que coleta dados de um paciente.
public class Paciente
{
    //Atributo Nome.
    public String Nome { get; set; }

    //Atributo Cns.
    public UInt64 Cns { get; set; }

    //Formatação para exibição.
    public override string ToString()
    {
        return $"Objeto: Paciente\nToString():\n{Nome}, {String.Format(@"{0:000 0000 0000 0000}", Cns)}\n";
    }

}
