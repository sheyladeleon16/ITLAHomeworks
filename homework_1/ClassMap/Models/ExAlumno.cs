using System.ComponentModel.DataAnnotations;
using ClassMap.Models;

public class ExAlumno : MiembroDeComunidad
{
private int _graduationYear
{
    get => _graduationYear; 
    set
    {
        int currentYear = DateTime.Now.Year;

        if (value < 1900 || value > currentYear)
        {
            throw new Exception("El año esta fuera de rango");
        }

        _graduationYear = value;
    }
}
    public override string GetRole()
    {
        return $"Egresado, Promoción: {_graduationYear}";
    }

}