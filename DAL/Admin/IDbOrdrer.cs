﻿using Model.Nettbutikk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Admin
{
    interface IDbOrdrer
    {
        List<Ordre> getOrdrer();
        Ordre getOrdre(int id);
    }
}
