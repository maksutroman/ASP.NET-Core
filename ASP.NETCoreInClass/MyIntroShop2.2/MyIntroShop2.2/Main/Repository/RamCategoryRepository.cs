﻿using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.Repository
{
    public class RamCategoryRepository : IRamCategory
    {
        private readonly DBContent dbContent;
        public RamCategoryRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        public IEnumerable<RamCategory> AllRamsCategories => dbContent.RamCategories;
    }
}
