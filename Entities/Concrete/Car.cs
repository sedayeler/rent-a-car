using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("brand_id")]
        public int BrandId { get; set; }
        [Column("color_id")]
        public int ColorId { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("year")]
        public int Year { get; set; }
        [Column("daily_price")]
        public decimal DailyPrice { get; set; }
        [Column("description")]
        public string Description { get; set; }
    }
}
