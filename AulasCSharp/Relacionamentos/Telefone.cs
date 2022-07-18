using System;

public class Telefone
{
    public Byte Ddd { get; set; }
    public Int32 Numero { get; set; }

    public Discente Discente { get; set; }

    public override string ToString()
    {
        return $"{String.Format("{0:(00)} {1:0000-0000}", Ddd, Numero)}";
    }
}
