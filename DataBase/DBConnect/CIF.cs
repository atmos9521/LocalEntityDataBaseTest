using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace DataBase.DBConnect
{
    [Table("CIF")]
    public class CIF : DbContext
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [Required]
        public int ID_Num { get; set; }
        [Required]
        public string Name { get; set; }
        public string Gender { get; set; }//性別
        public string Tel_Num { get; set; }
        public string Adress { get; set; }
        public string SmartPhone_Num { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnterDate { get; set; }        
    }
}
