using AutoMapper;
using Ls.Utilities;
using System;
using UAV.AppManagePlatform.Domain.Entities.Authorization;
using UAV.AppManagePlatform.Dto.Business.Sys.MenuManage;
using UAV.AppManagePlatform.Dto.Business.Sys.PermissionManage;
using UAV.AppManagePlatform.Dto.Business.Sys.RoleManage;
using UAV.AppManagePlatform.Dto.Business.Sys.UserManage;
using Auth = UAV.AppManagePlatform.Domain.Entities.Authorization;

namespace UAV.AppManagePlatform.Application
{
    public static class ApplicationStartUp
    {
        public static void AutoMapInit()
        {
            #region 系统管理

            #region 菜单管理
            Mapper.CreateMap<Menu, MenuDto>();
            Mapper.CreateMap<MenuDto, Menu>()
                .AfterMap((src, dest) => dest.Id = LsIdGenerator.CreateIdentity());
            #endregion
            
            #region 角色管理
            Mapper.CreateMap<Role, RoleDto>();
            Mapper.CreateMap<RoleDto, Role>()
                .AfterMap((src, dest) => dest.Id = LsIdGenerator.CreateIdentity());
            #endregion

            #region 用户管理
            Mapper.CreateMap<User, UserDto>()
                .ForMember(ts => ts.CreatedTime, opt => opt.MapFrom(td => td.CreatedTime.ToString("yyyy-MM-dd HH:mm:ss")))
                .ForMember(ts => ts.LastUpdatedTime, opt => opt.MapFrom(td => td.LastUpdatedTime.ToString("yyyy-MM-dd HH:mm:ss")))
                .ForMember(ts => ts.Role, opt => opt.MapFrom(td => td.Role));
            Mapper.CreateMap<UserDto, User>()
                .ForMember(ts => ts.UserName, opt => opt.MapFrom(td => td.UserName))
                .ForMember(ts => ts.LoginId, opt => opt.MapFrom(td => td.UserName))
                .AfterMap((src, dest) => dest.Id = LsIdGenerator.CreateIdentity());
            #endregion
            #endregion
        }
    }
}
