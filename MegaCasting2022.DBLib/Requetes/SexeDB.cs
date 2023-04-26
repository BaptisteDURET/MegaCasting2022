using MegaCasting2022.DBLib.tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting2022.DBLib.Requetes
{
    public static class SexeDB
    {
        public static List<Sexe> All()
        {
            using var context = new MegaCasting2022Context();
            return context.Sexes.ToList();
        }

        public static List<int> AllByCastingId(int id)
        {
            using var context = new MegaCasting2022Context();
            return context.Recherche.Where(cs => cs.CastingId == id).Select(cs => cs.SexeId).ToList();
        }
    }
}
