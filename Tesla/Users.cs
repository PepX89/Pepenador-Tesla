using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla
{
    public static class Users
    {
        public static List<Register> Usuarios { get; set; } = new List<Register> { };
    
    
        public static Register Obtener(string user)
        {
            return Usuarios.FirstOrDefault(o => o.User == user);
        }
    }
}

