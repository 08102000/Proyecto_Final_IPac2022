using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Final.Data
{
    public class MySQLConfiguration
    {
        public string CadenaConexion { get; }

        public MySQLConfiguration(string codenaConexion)
        {
            CadenaConexion = codenaConexion;
        }

    }
}
