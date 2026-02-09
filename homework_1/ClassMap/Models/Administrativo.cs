using ClassMap.Models;

public class Administrativo : Empleado
{
    public string Position { get; set;}

    public override string ToString()
    {
        return base.ToString() + $" Area de Gestion: {Position}";
    }
}

