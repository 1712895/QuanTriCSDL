using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebTest.Models
{
    public class Thongsokythuat
    {
        [BsonElement("Xuatxuthuonghieu")]
        public string Xuatxuthuonghieu { get; set; }
        [BsonElement("Xuatxu")]
        public string Xuatxu        { get; set; }
        [BsonElement("Model")]
        public string Model { get; set; }
        [BsonElement("ThuongHieu")]
        public string ThuongHieu { get; set; }
    }
    public class ProductModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("sku")]
        public string sku { get; set; }
        [BsonElement("Ten")]
        public string Ten { get; set; }
        [BsonElement("MoTA")]
        public string MoTA { get; set; }
        [BsonElement("ThongSoKyThuat")]
        public Thongsokythuat ThongSoKyThuat { get; set; }
        [BsonElement("NguyenKien")]
        public List<string> NguyenKien { get; set; }
        [BsonElement("Categories")]
        public List<string> Categories { get; set; }
        [BsonElement("giaTien")]
        public string giaTien   { get; set; }

    }
}