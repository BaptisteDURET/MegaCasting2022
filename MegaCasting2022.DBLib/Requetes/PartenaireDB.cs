using MegaCasting2022.DBLib.tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting2022.DBLib.Requetes
{
    public static class PartenaireDB
    {
        public static List<PartenaireDiffusion> All()
        {
            using (var context = new MegaCasting2022Context())
            {
                return context.PartenaireDiffusions.ToList();
            }
        }

        public static void Delete(PartenaireDiffusion partenaire)
        {
            using (var context = new MegaCasting2022Context())
            {
                context.PartenaireDiffusions.Remove(partenaire);
                context.SaveChanges();
            }
        }

        public static void Update(PartenaireDiffusion partenaire)
        {
            using (var context = new MegaCasting2022Context())
            {
                context.PartenaireDiffusions.Update(partenaire);
                context.SaveChanges();
            }
        }

        public static void Insert(PartenaireDiffusion partenaire)
        {
            using (var context = new MegaCasting2022Context())
            {
                context.PartenaireDiffusions.Add(partenaire);
                context.SaveChanges();
            }
        }
    }
}
