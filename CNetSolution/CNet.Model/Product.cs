using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNet.Model
{
    public class Product
    {
        #region Properties 

        [Key] public Guid ProductID { get; set; }
        public string Key { get; set; }

        public double? UnitPrice { get; set; }
        public DateTime PublishingDate { get; set; }

        #endregion

        #region Navigation Properties

        public virtual ProductType Type { get; set; }
        public virtual List<Translation> Translations { get; set; }

        #endregion

        #region Constructors

        public Product() 
        {
            PublishingDate = DateTime.Now;
        }

        #endregion
    }
}
