using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Timing;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using nercoreangular.Manager.Author.Dtos;
using nercoreangular.Models;
using Newtonsoft.Json;

namespace nercoreangular.Manager.Author
{
    public class AuthorAppService : nercoreangularAppServiceBase, IAuthorAppService
    {
        private readonly IRepository<Models.Author, long> authorRepository;

        public AuthorAppService(
            IRepository<Models.Author, long> _authorRepository
            )
        {
            authorRepository = _authorRepository;
        }

        /// <summary>
        /// Lấy ra danh sách tacs giả
        /// </summary>
        /// <returns></returns>
        /// 

        public async Task<PagedResultDto<AuthorDto>> GetAll(SearchAuthorInput input)
        {

            long us_id = 2;

            if (AbpSession.UserId.HasValue)
            {
                var q = authorRepository.GetAll().Where(a => a.au_is_deleted == false);
                if (input.au_search != null && input.au_search.Length > 0)
                {
                    q = q.Where(a =>
                        (a.au_code != null && a.au_code.ToLower().Contains(input.au_search.ToLower())) ||
                        (a.au_name != null && a.au_name.ToLower().Contains(input.au_search.ToLower())) ||
                        (a.au_pen_name != null && a.au_pen_name.ToLower().Contains(input.au_search.ToLower())) ||
                        (a.au_email != null && a.au_email.ToLower().Contains(input.au_search.ToLower())));
                }

                var total = await q.CountAsync();
                if (input.MaxResultCount > 0)
                {
                    q = q.Skip(input.SkipCount).Take(input.MaxResultCount);
                }
                var tasks = await q.ToListAsync();
                List<AuthorDto> listAll = ObjectMapper.Map<List<AuthorDto>>(tasks);
                return new PagedResultDto<AuthorDto>(total, listAll);
            }
            throw new UserFriendlyException("Vui lòng đăng nhập");
        }

        public async Task<AuthorDto> CreateAuthor(CreateAuthorInput input)
        {
            long us_id = 2;

            if (AbpSession.UserId.HasValue)
            {
                us_id = (long)AbpSession.UserId;
                
                Models.Author author = ObjectMapper.Map<Models.Author>(input);

                author.au_is_deleted = false;
                author.au_created_at = Clock.Now;
                author.au_updated_at = Clock.Now;
                author = await authorRepository.InsertAsync(author);
                await CurrentUnitOfWork.SaveChangesAsync();
                var resultCreate = ObjectMapper.Map<AuthorDto>(author);
                return resultCreate;
            }
            throw new UserFriendlyException("Vui lòng đăng nhập");
        }

        public async Task<AuthorDto> UpdateAuthor(UpdateAuthorInput input)
        {
            long us_id = 2;

            if (AbpSession.UserId.HasValue)
            {
                
                var author = await authorRepository.GetAsync(input.au_id);
                if (author == null)
                {
                    throw new UserFriendlyException(L("NotFoundData"));
                }

                author.au_code = input.au_code;
                author.au_name = input.au_name;
                author.au_dob = input.au_dob;
                author.au_address = input.au_address;
                author.au_decs = input.au_decs;
                author.au_email = input.au_email;
                author.au_academic_rank = input.au_academic_rank;
                author.au_degree = input.au_degree;
                author.au_pen_name = input.au_pen_name;
                author.au_infor = input.au_infor;
                author.fi_id = JsonConvert.SerializeObject(input.fi_id);
                author = await authorRepository.UpdateAsync(author);
                await CurrentUnitOfWork.SaveChangesAsync();
                var result = ObjectMapper.Map<AuthorDto>(author);
                return result;
                
            }
            throw new UserFriendlyException("Vui lòng đăng nhập");
        }
        public async Task<bool> ChangePosition(UpdatePositionAuthorInput input)
        {
            long us_id = 2;

            if (AbpSession.UserId.HasValue)
            {

                var index1 = await authorRepository.GetAsync(input.au_id);
                var index2 = await authorRepository.GetAsync(input.au_id2);
                if (index1 == null || index2 == null)
                {
                    return false;
                }
                //var temp1 = index1.in_sort;
                //index1.in_sort = index2.in_sort;
                //index2.in_sort = temp1;

                authorRepository.Update(index1);
                authorRepository.Update(index2);
                await CurrentUnitOfWork.SaveChangesAsync();

                return true;

            }
            throw new UserFriendlyException("Vui lòng đăng nhập");
        }
        /// <summary>
        /// Xóa 1 bản log
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// 
        public async Task<bool> Delete(EntityDto<long> input)
        {
            if (AbpSession.UserId.HasValue)
            {
                var author =await authorRepository.GetAsync(input.Id);
                if (author == null) {
                    throw new UserFriendlyException(L("NotFoundData"));

                }
                author.au_is_deleted = true;
                author.au_updated_at = Clock.Now;
                await authorRepository.UpdateAsync(author);

                await CurrentUnitOfWork.SaveChangesAsync();
                return true;

            }
            throw new UserFriendlyException(L("PleaseLoginAgain"));
        }
        
    }
}
