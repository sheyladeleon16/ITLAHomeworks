using ClassMap.Models;

public class Estudiante : MiembroDeComunidad
{
    public string Career { get; set; }

    public override string GetRole()
    {
        return $"Estudiante de {Career}";
    }

}