using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace nercoreangular.Manager.Author.Dtos
{
    public class CreateAuthorInput
    {

        public string au_code { get; set; }
        public string au_name { get; set; }
        public string au_dob { get; set; }
        public string au_address { get; set; }
        public string au_decs { get; set; }
        public string au_email { get; set; }
        public string au_academic_rank { get; set; }
        public string au_degree { get; set; }
        public string au_pen_name { get; set; }
        public string au_infor { get; set; }
        public string fi_id { get; set; }


    }
}
