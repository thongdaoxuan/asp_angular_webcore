using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;



namespace nercoreangular.Manager.Author.Dtos
{
    public class SearchAuthorInput : PagedResultRequestDto
    {
        public string au_search { get; set; }
    }
}
