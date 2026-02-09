using System.ComponentModel.DataAnnotations;
using ClassMap.Models;


class Comunidad
{
    static void Main()
    {
       Dictionary<string, MiembroDeComunidad> comunidad = new();

        var estudiante = new Estudiante
        {
            Id = 1,
            Name = "Ana",
            Email = "anabelle@gmail.com",
            Career = "Marketing"
            
        };

        var maestro = new Maestro
        {
            Id = 2,
            Name = "Juan",
            Email = "Juanpa2345@outlook.com",
            Subject = "Matematicas",
            grade = "Segundo"

        };

        var administrativo = new Administrativo
        {
           Id = 3,
           Name = "Carmen",
           Email = "ccrmencomer67@gmail.com",
           Departament = "Finanzas",
           JobTitle = "Analísta de Riego Financiero",
           Position = "Gerencia"
        };

        comunidad.Add(estudiante.Id.ToString(), estudiante);
        comunidad.Add(maestro.Id.ToString(), maestro);
        comunidad.Add(administrativo.Id.ToString(), administrativo);


        Console.WriteLine("Lista de miembros de la comunidad: ");

        foreach (var miembro in comunidad.Values)
        {
            Console.WriteLine(miembro);
        }

    }
}
