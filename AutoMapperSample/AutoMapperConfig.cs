using AutoMapper;
using AutoMapperSample.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperSample
{
    /// <summary>
    /// 静态全局 AutoMapper 配置文件
    /// </summary>
    public partial class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AuthorProfile());
                cfg.AddProfile(new OrderProfile());
            });
        }
    }
}
