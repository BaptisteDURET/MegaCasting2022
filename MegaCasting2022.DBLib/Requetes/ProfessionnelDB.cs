﻿using MegaCasting2022.DBLib.tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting2022.DBLib.Requetes
{
    public static class ProfessionnelDB
    {
        public static List<Professionnel> All()
        {
            using (var context = new MegaCasting2022Context())
            {
                return context.Professionnels.ToList();
            }
        }

        public static void Delete(Professionnel p)
        {
            using (var context = new MegaCasting2022Context())
            {
                if (p != null)
                {
                    context.Professionnels.Remove(p);
                    context.SaveChanges();
                }
            }
        }
    }
}
