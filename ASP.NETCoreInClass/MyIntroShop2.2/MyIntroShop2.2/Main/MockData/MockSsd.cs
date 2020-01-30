﻿using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.MockData
{
    public class MockSsd : IAllSsd
    {

        private readonly ISsdCategory _ssdCategory = new MockSsdCategory();
        public IEnumerable<Ssd> ssds
        {
            get
            {
                return new List<Ssd>
                {
                    new Ssd
                    {
                        name = "Samsung S10",
                        description = "Best phone by sumsung",
                        img = "https://i2.rozetka.ua/goods/11052630/samsung_galaxy_s10_plus_6_128_gb_black_sm_g975fzkdsek_images_11052630657.jpg",
                        price = 23000,
                        SsdCategory = _ssdCategory.AllSsdsCategories.First()
                    },
                    new Ssd
                    {
                        name = "Nokia 3310",
                        description = "Old phone",
                        img = "https://static.turbosquid.com/Preview/001329/666/6L/_DHQ.jpg",
                        price = 700,
                        SsdCategory = _ssdCategory.AllSsdsCategories.Last()
                    },
                    new Ssd
                    {
                        name = "Lenovo z-5",
                        description = "Best phone by Lenovo",
                        img = "https://i.allo.ua/media/catalog/product/cache/1/image/425x295/799896e5c6c37e11608b9f8e1d047d15/f/i/file_613_3.jpg",
                        price = 3900,
                        SsdCategory = _ssdCategory.AllSsdsCategories.First()
                    },
                    new Ssd
                    {
                        name = "Xiaomi Redmy 8",
                        description = "Best phone by Xiaomi",
                        img = "https://i8.rozetka.ua/goods/14142417/xiaomi_redmi_note_8_pro_6_128_black_images_14142417355.jpg",
                        price = 6999,
                        SsdCategory = _ssdCategory.AllSsdsCategories.First()
                    }
                };
            }
        }
    }
}
