using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace AgendamientoTagliacozzo
{
    public class T_Paciente
    {
        [PrimaryKey, AutoIncrement]
        public int codigo { get; set; }
        [MaxLength(255)]
        public string nombre { get; set; }
        [MaxLength(255)]
        public string apellido { get; set; }
        [MaxLength(255)]
        public int edad { get; set; }
        [MaxLength(255)]
        public string direccion { get; set; }
        [MaxLength(255)]
        public string telefono { get; set; }
        [MaxLength(255)]
        public string estudio { get; set; }
        [MaxLength(255)]
        public string fecha { get; set; }
        [MaxLength(255)]
        public string horario { get; set; }
        [MaxLength(255)]
        public string usuario { get; set; }
        
        
     
    }
}
