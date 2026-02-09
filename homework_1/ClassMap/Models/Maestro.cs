using ClassMap.Models;

public class Maestro : Docente
{
    public required string grade { get; set; }

    public override string ToString()
    {
        return $"Grado: {grade}";
    }
}