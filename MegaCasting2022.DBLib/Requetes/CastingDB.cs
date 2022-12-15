using MegaCasting2022.DBLib.tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting2022.DBLib.Requetes
{
    public static class CastingDB
    {
        public static List<Casting> All()
        {
            using (var context = new MegaCasting2022Context())
            {
                return context.Castings.ToList();
            }
        }
    }
}
