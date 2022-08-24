using System;

namespace Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Documento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public byte Hijos { get; set; }
        public decimal Sueldo { get; set; }
    }
}
