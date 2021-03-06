using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace pjModels
{
    [Table("Writers")]
    public class Writer
    {
        public int id { get; set; }
        [required]
        [Column(TypeName = "nvarchar")]
        [StringLength(250)]
        public string Name { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }

    }
}
