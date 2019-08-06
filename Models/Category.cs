using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Models
{
    public class Category
    {
        public string BannerCode { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public static IQueryable<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category {
                    BannerCode = "PB",
                    CategoryID = 1,
                    CategoryName = "PictureBannerA"
                },
                new Category {
                    BannerCode = "PB",
                    CategoryID = 2,
                    CategoryName = "PictureBannerB"
                },
                new Category {
                    BannerCode = "VB",
                    CategoryID = 3,
                    CategoryName = "VideoBannerA"
                },
                new Category {
                    BannerCode = "VB",
                    CategoryID = 4,
                    CategoryName = "VideoBannerB"
                },

                new Category {
                    BannerCode = "PBVB",
                    CategoryID = 5,
                    CategoryName = "PictureAndVideoBannerA"
                },
                new Category {
                    BannerCode = "PBVB",
                    CategoryID = 6,
                    CategoryName = "PictureAndVideoBannerB"
                },

            }.AsQueryable();
        }
    }
}