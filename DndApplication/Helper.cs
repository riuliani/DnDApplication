using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DndApplication
{
    class Helper
    {
        public static string CnnVal(string DnD)
        {
            return ConfigurationManager.ConnectionStrings[DnD].ConnectionString;
        }
    }
}
