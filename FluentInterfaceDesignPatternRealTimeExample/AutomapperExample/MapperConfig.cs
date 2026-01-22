using AutoMapper;
using Microsoft.Extensions.Logging;

namespace FluentInterfaceDesignPatternRealTimeExample.AutomapperExample
{
    public class MapperConfig
    {
        
        public static IMapper InitializeAutomapper()
        {
            ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Customer, CustomerDTO>()
                   .ForMember(dest => dest.FullName,
                        opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
            }, loggerFactory);

            IMapper mapper = config.CreateMapper();
            return mapper;
        }
    }
}
