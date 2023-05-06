using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia
{
    internal class Conexao
    {
      static string conexao = @"Data Source=MAYCON-PC\SQLEXPRESS;Initial Catalog=Farmacia;Integrated Security=True";



        public static string Conectar()
        {
            return conexao;
        }
    }
}
