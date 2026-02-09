using ClassMap.Models;

public class Administrador : Docente
{
    public required string ManagmentArea { get; set; }

    public override string GetRole()
    {
        return $"Área de Gestión: {ManagmentArea}";
    }
}