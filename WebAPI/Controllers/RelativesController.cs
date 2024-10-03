using System.Security.Claims;
using Asp.Versioning;
using Azure.Core;
using Contracts.IService;
using Entities.Constant;
using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Models;
using Entities.IdentityExtensions;
using Entities.Models;
using Features.CustomRequest;
using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class RelativesController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IRelativesService _relativesService;

        public RelativesController(IRelativesService RelativesService, IConfiguration configuration)
        {
            _configuration = configuration;
            _relativesService = RelativesService;
        }

        /// <summary>
        /// گرفتن اطلاعات ثبت شده برای کاربر درخواست دهنده
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
       
        [HttpGet("[action]")]
        public async Task<IActionResult> GetRelatives()
        {
            try
            {
                var UserId = base.User.GetUserId();
                if (UserId == null)
                    throw new Exception("User not found!");

                var res = await _relativesService.GetbyUserId(UserId.Value);
                return Ok(res);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while retrieving User's Relatives!");
            }
        }

        /// <summary>
        /// افزودن نسبت برای کاربر درخواست دهنده
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
       
        [HttpPost("[action]")]
        public async Task<IActionResult> AddRelative([FromBody] RelativeDto dto)
        {
            try
            {
                var res = await _relativesService.InsertByUser(dto);
                return Ok(res);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while inserting User's Relatives!");
            }
        }

        /// <summary>
        /// افزودن نسبت ها برای کاربر درخواست دهنده
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
       
        [HttpPost("[action]")]
        public async Task<IActionResult> AddRelatives([FromBody] List<RelativeDto> dto)
        {
            try
            {
                var res = await _relativesService.BulkInsertByUser(dto);
                return Ok(res);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while inserting User's Relatives!");
            }
        }

        /// <summary>
        /// ویرایش نسبت ها برای کاربر درخواست دهنده
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
       
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateRelative([FromBody] RelativeDto dto)
        {
            try
            {
                var res = await _relativesService.UpdateByUser(dto);
                return Ok(res);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while updating User's Relatives!");
            }
        }



        /// <summary>
        /// ویرایش نسبت ها برای کاربر درخواست دهنده
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        [HttpPost("[action]")]
        public async Task<IActionResult> ManiuplateRelative([FromBody] ManiuplateRelativeDto dto)
        {
            try
            {
                var res = await _relativesService.ManiuplateRelatives(dto);
                return Ok(res);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while updating User's Relatives!");
            }
        }


        /// <summary>
        /// ویرایش نسبت ها برای کاربر درخواست دهنده
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [Authorize(Roles = $"{RolesNamesConstant.Administrator},{RolesNamesConstant.Manager}")]
        [HttpPost("[action]")]
        public async Task<IActionResult> ManiuplateUserRelative([FromBody] ManiuplateRelativeDto dto)
        {
            try
            {
                if (base.User.IsInRoles(new() { RolesNamesConstant.Administrator }))
                {
                    var res = await _relativesService.ManiuplateRelativesAsAdmin(dto);
                    return Ok(res);
                }
                else if (base.User.IsInRoles(new() { RolesNamesConstant.Manager }))
                {
                    var res = await _relativesService.ManiuplateRelativesAsCompany(dto);
                    return Ok(res);
                }


                return Forbid();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while updating User's Relatives!");
            }
        }


        /// <summary>
        /// فعال و غیرفعال سازی نسبت برای کاربر درخواست دهنده
        /// </summary>
        /// <param name="dto">Id</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        [HttpDelete("[action]")]
        public async Task<IActionResult> ToggleRelative([FromBody] RelativeDto dto)
        {
            try
            {
                var res = await _relativesService.ToggleByUser(dto.Id.Value);
                return Ok(res);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while toggling User's Relatives!");
            }
        }

        /// <summary>
        /// گرفتن اطلاعات نسبت های تایید شده برای کاربر درخواست دهنده
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
       
        [HttpGet("[action]")]
        public async Task<IActionResult> GetConfirmedRelatives()
        {
            try
            {
                var UserId = base.User.GetUserId();
                if (UserId == null)
                    throw new Exception("User not found!");

                var res = await _relativesService.GetConfirmedRelatives(UserId.Value);
                return Ok(res);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while retrieving User's Relatives!");
            }
        }


        /// <summary>
        /// افزودن نسبت ها برای کاربر -- در سطح شرکت و ادمین
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        [Authorize(Roles = $"{RolesNamesConstant.Administrator},{RolesNamesConstant.Manager}")]
        [HttpPost("admin/[action]")]
        public async Task<IActionResult> AddToUserRelatives([FromBody] UserRelativesCreationDto dto)
        {
            try
            {
                if (base.User.IsInRoles(new() { RolesNamesConstant.Administrator }))
                {
                    var res = await _relativesService.BulkInsertByAdmin(dto);
                    return Ok(res);
                }
                else if (base.User.IsInRoles(new() { RolesNamesConstant.Manager }))
                {
                    var res = await _relativesService.BulkInsertByCompany(dto);
                    return Ok(res);
                }

                return Forbid();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while inserting User's Relatives!");
            }
        }



        /// <summary>
        /// ویرایش نسبت ها برای کاربر -- در سطح شرکت و ادمین
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        [Authorize(Roles = $"{RolesNamesConstant.Administrator},{RolesNamesConstant.Manager}")]
        [HttpPut("admin/[action]")]
        public async Task<IActionResult> UpdateUserRelative([FromBody] RelativeDto dto)
        {
            try
            {
                if (base.User.IsInRoles(new() { RolesNamesConstant.Administrator }))
                {
                    var res = await _relativesService.UpdateByAdmin(dto);
                    return Ok(res);
                }
                else if (base.User.IsInRoles(new() { RolesNamesConstant.Manager }))
                {
                    var res = await _relativesService.UpdateByCompany(dto);

                    return Ok(res);
                }

                return Forbid();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while updating User's Relatives!");
            }
        }



        /// <summary>
        /// فعال و غیرفعال سازی نسبت برای کاربر -- در سطح شرکت و ادمین
        /// </summary>
        /// <param name="dto">UserId - Id</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        [Authorize(Roles = $"{RolesNamesConstant.Administrator},{RolesNamesConstant.Manager}")]
        [HttpDelete("admin/[action]")]
        public async Task<IActionResult> ToggleUserRelative([FromBody] RelativeDto dto)
        {
            try
            {
                if (base.User.IsInRoles(new() { RolesNamesConstant.Administrator }))
                {
                    var res = await _relativesService.ToggleByAdmin(Guid.Parse(dto.UserId), dto.Id.Value);
                    return Ok(res);
                }
                else if (base.User.IsInRoles(new() { RolesNamesConstant.Manager }))
                {
                    var res = await _relativesService.ToggleByCompany(
                        Guid.Parse(dto.UserId),
                        dto.Id.Value
                    );

                    return Ok(res);
                }

                return Forbid();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while toggling User's Relatives!");
            }
        }


        /// <summary>
        /// گرفتن اطلاعات نسبت های بررسی نشده - سطح ادمین
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        [Authorize(Roles = $"{RolesNamesConstant.Administrator},{RolesNamesConstant.Manager}")]
        [HttpPost("admin/[action]")]
        public async Task<IActionResult> GetAllNotCheckedRelatives(
            [FromBody] ListNotCheckedRelativesRequest request
        )
        {
            try
            {
                if (base.User.IsInRoles(new() { RolesNamesConstant.Administrator }))
                {
                    var res = await _relativesService.GetNotCheckedRelativesAsAdmin(request);
                    return Ok(res);
                }
                else if (base.User.IsInRoles(new() { RolesNamesConstant.Manager }))
                {
                    var res = await _relativesService.GetNotCheckedRelativesAsCompany(request);
                    return Ok(res);
                }

                return Forbid();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while retrieving all unchecked Relatives!");
            }
        }

        /// <summary>
        /// تعیین وضعیت نسبت  برای کاربر -- در سطح شرکت و ادمین
        /// </summary>
        /// <param name="dto">userId - Id - IsConfirmed</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        [Authorize(Roles = $"{RolesNamesConstant.Administrator},{RolesNamesConstant.Manager}")]
        [HttpPut("admin/[action]")]
        public async Task<IActionResult> CheckUserRelative([FromBody] RelativeDto dto)
        {
            try
            {
                if (base.User.IsInRoles(new() { RolesNamesConstant.Administrator }))
                {
                    var res = await _relativesService.ResultOfReviewRelativeByAdmin(
                        Guid.Parse(dto.UserId),
                        dto.Id.Value,
                        dto.IsConfirmed
                    );

                    return Ok(res);
                }
                else if (base.User.IsInRoles(new() { RolesNamesConstant.Manager }))
                {
                    var res = await _relativesService.ResultOfReviewRelativeByCompany(
                        Guid.Parse(dto.UserId),
                        dto.Id.Value,
                        dto.IsConfirmed
                    );

                    return Ok(res);
                }

                return Forbid();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while checking User's Relatives!");
            }
        }
    }
}
