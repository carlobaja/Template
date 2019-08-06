using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Models
{
    public class BannerType 
    {
        public string BannerCode { get; set; }
        public string BannerName { get; set; }

        public static IQueryable<BannerType> GetBannerType()
        {
            return new List<BannerType>
            {
                new BannerType {
                    BannerCode = "PB",
                    BannerName = "PictureBanner"
                },
                new BannerType {
                    BannerCode = "VB",
                    BannerName = "VideoBanner"
                },
                new BannerType {
                    BannerCode = "PBVB",
                    BannerName = "PictureAndVideoBanner"
                },

            }.AsQueryable();
        }
    }
}