﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nettbutikk.DAL;
using Nettbutikk.Model;

namespace BLL
{
    public class SkoBLL : ISkoLogikk
    {
        public List<Skoen> hentAlleSko()
        {
            return DbSko.hentAlleSko();
        }

        public List<Skoen> hentAlleSkoFor(int forHvemId)
        {
            return DbSko.hentAlleSkoFor(forHvemId);
        }

        public List<Skoen> hentAlleSkoFor(int forHvemId, int kategoriId)
        {
            return DbSko.hentAlleSkoFor(forHvemId, kategoriId);
        }

        public Skoen hentEnSko(int skoId)
        {
            return DbSko.hentEnSko(skoId);
        }

        public List<ForHvem> hentAlleForHvem()
        {
            return hentAlleForHvem();
        }

        public List<Kategori> hentAlleKategorierForHvem(int forHvemId)
        {
            return DbSko.hentAlleKategorierForHvem(forHvemId);
        }

        public ForHvem getFor(int forId)
        {
            return getFor(forId);
        }

        public Kategori getKategori(int kategoriId)
        {
            return getKategori(kategoriId);
        }
    }
}
