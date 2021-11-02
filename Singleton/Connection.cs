using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Connection
    {
        public string conn = "";
        private static Connection connection = null;

        protected Connection()
        {
            conn = "New Connection";
            // Configurar la conexión a la DB u otros.
        }

        public static Connection getConnection
        {
            get
            {
                if (connection == null)
                    connection = new Connection();
                return connection;
            }
        }
    }
}
