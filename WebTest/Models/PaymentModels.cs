using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTest.Models;
namespace WebTest.Models
{
    public class PaymentModels
    {
        QuanTriCSDLEntities pay = new QuanTriCSDLEntities();
        public IEnumerable<DonHang> layds()
        {
            return pay.DonHang.ToList();
        }
        public DonHang lays(int id)
        {
            return pay.DonHang.Find(id);
        }
        public void them(DonHang n)
        {
            pay.DonHang.Add(n);
            pay.SaveChanges();
        }
    }
}