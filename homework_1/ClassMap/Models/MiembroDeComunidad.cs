namespace ClassMap.Models
{
    public class MiembroDeComunidad
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }

        public virtual string GetRole()
        {
            return $"Miembro de la comunidad";
        }
        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Name}, Correo: {Email}, Rol: {GetRole()}";
        }
    }

}