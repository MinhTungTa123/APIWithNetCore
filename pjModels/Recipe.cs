using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pjModels
{
    [Table("Recipes")]
    public class Recipe
    {
        
        public int id { get; set; }
        [required]
        [Column(TypeName ="nvarchar")]
        [StringLength(250)]
        public string Title { get; set; }
        public string Content { get; set; }
        [ForeignKey("Writeid")]
        public int WriteID { get; set; }
        public virtual Writer Writer { get; set; }

    }
}
