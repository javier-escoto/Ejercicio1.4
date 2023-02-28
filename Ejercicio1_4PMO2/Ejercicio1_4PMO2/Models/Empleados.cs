using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1_4PMO2.Models
{
    public class Empleados
    {

        [PrimaryKey, AutoIncrement]
        public int codigo { get; set; }

        public String nombres { get; set; }

        public String descripcion { get; set; }

        public byte[] imagen { get; set; }
    }
}
