using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Models
{
    public class Banner
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public decimal Size { get; set; }

        public static IQueryable<Banner> GetBanner()
        {
            return new List<Banner>
            {
                new Banner {
                    Category = "PictureBannerA",
                    Name = "PictureA",
                    Size = 999m
                },
                new Banner {
                    Category = "PictureBannerB",
                    Name = "PictureB",
                    Size = 1299m
                },
                new Banner {
                    Category = "VideoBannerA",
                    Name = "VideoA",
                    Size = 1992m
                },
                new Banner {
                    Category = "VideoBannerB",
                    Name = "VideoB",
                    Size = 1599m
                },
                new Banner {
                    Category = "PictureAndVideoBannerA",
                    Name = "PictureVideoA",
                    Size = 1099m
                },
                new Banner {
                    Category = "PictureAndVideoBannerB",
                    Name = "PictureVideoB",
                    Size = 2100m
                },

            }.AsQueryable();
        }
    }
}