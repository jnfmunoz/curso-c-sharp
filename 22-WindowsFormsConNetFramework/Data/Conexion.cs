using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Conexion : LinqToDB.Data.DataConnection
    {
        public Conexion(): base("PHDN1") { }        
        public ITable<Estudiante> _Estudiante => this.GetTable<Estudiante>();

    }
}
