using ClassMap.Models;

public class Empleado : MiembroDeComunidad
{
    public string Departament { get; set; }
    public string JobTitle { get; set; }

    public override string GetRole()
    {
        return "Empleado";
    }

    public override string ToString()
    {
        return base.ToString() + $", Departamento: {Departament}, Cargo: {JobTitle},";
    }
}