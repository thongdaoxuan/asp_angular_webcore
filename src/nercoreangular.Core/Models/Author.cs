using Abp.Domain.Entities;
using Abp.Timing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace nercoreangular.Models
{
    public partial class Author : Entity<long>
    {
        [Column("au_id")]

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override long Id
        {
            get;
            set;
        }

        [NotMapped]
        public long au_id { get { return this.Id; }}
        
        [MaxLength(50)]
        public string au_code { get; set; }

        [MaxLength(50)]
        public string au_name { get; set; }
        [MaxLength(50)]
        public string au_dob { get; set; }
        [MaxLength(150)]
        public string au_address { get; set; }
        [MaxLength(500)]
        public string au_decs { get; set; }
        [MaxLength(50)]
        public string au_email { get; set; }
        [MaxLength(50)]
        public string au_academic_rank { get; set; }
        [MaxLength(50)]
        public string au_degree { get; set; }
        [MaxLength(50)]
        public string au_pen_name { get; set; }
        [MaxLength(500)]
        public string au_infor { get; set; }
        public bool au_is_deleted { get; set; }
        public string fi_id { get; set; }
        [DisableDateTimeNormalization]

        [Column(TypeName = "datetime")] 
        public System.DateTime au_created_at { get; set; }

        [DisableDateTimeNormalization]

        [Column(TypeName = "datetime")] 
        public System.DateTime au_updated_at { get; set; }


        public Author()
        {
            au_updated_at = Clock.Now;
            au_created_at = Clock.Now;
            au_is_deleted = false;
        }
    }
}
