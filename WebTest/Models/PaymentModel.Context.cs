//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebTest.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QuanTriCSDLEntities : DbContext
    {
        public QuanTriCSDLEntities()
            : base("name=QuanTriCSDLEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<DonHang> DonHang { get; set; }
    
        public virtual int sp_ThanhToanGioHang(string hinhthucgiao, string hinhthucthanhtoan, Nullable<int> productID, Nullable<double> tongTien)
        {
            var hinhthucgiaoParameter = hinhthucgiao != null ?
                new ObjectParameter("Hinhthucgiao", hinhthucgiao) :
                new ObjectParameter("Hinhthucgiao", typeof(string));
    
            var hinhthucthanhtoanParameter = hinhthucthanhtoan != null ?
                new ObjectParameter("Hinhthucthanhtoan", hinhthucthanhtoan) :
                new ObjectParameter("Hinhthucthanhtoan", typeof(string));
    
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("ProductID", productID) :
                new ObjectParameter("ProductID", typeof(int));
    
            var tongTienParameter = tongTien.HasValue ?
                new ObjectParameter("TongTien", tongTien) :
                new ObjectParameter("TongTien", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ThanhToanGioHang", hinhthucgiaoParameter, hinhthucthanhtoanParameter, productIDParameter, tongTienParameter);
        }
    }
}
