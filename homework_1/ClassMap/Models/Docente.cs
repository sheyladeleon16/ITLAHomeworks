using ClassMap.Models;

public class Docente : Empleado
{
    public string Subject { get; set; }

    public override string GetRole()
    {
        return $"Docente";
    }

    public override string ToString()
    {
        return base.ToString() + $" Asignatura: {Subject}" ;
    }
}