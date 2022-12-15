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

        public static void Delete(Casting casting)
        {
            using (var context = new MegaCasting2022Context())
            {
                context.Castings.Remove(casting);
                context.SaveChanges();
            }
        }

        public static void Update(Casting casting)
        {
            using (var context = new MegaCasting2022Context())
            {
                context.Castings.Update(casting);
                context.SaveChanges();
            }
        }

        public static void Insert(Casting casting)
        {
            using (var context = new MegaCasting2022Context())
            {
                context.Castings.Add(casting);
                context.SaveChanges();
            }
        }
    }
}
