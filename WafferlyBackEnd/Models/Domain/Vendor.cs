using System;
namespace WafferlyBackEnd.Models.Domain
{
    public class Vendor
    {
        public Vendor()
        {
        }
        public string Id
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
        public string Desc
        {
            get;
            set;
        }
        public string VendorLogoPath
        {
            get;
            set;
        }
        //public string[] Locations
        //{
        //    get;
        //    set;
        //}
        public List<Item> Items { get; set; }
    }
}
