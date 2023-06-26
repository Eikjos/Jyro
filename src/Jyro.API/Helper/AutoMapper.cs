using AutoMapper;
using System.Net.NetworkInformation;
using System.Security.Cryptography.Xml;

namespace Jyro.API.Helper
{
    public class AutoMapper
    {
        public static  Mapper GetMapper<S, D>() where S : class where D : class
        {
            var config = new MapperConfiguration(mge =>
            {
                mge.CreateMap<S, D>();
            });

            return new Mapper(config);
        }
    }
}
