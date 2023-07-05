using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace nercoreangular.Manager.Author.Dtos
{
    public class UpdatePositionAuthorInput
    {
        [Required]
        public long au_id { get; set; }
        public long au_id2 { get; set; }
    }
}
