using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFNavigationPropertyMapping.Contracts.DataContracts;
using WCFNavigationPropertyMapping.Lib.EntityFrameworkModel;

namespace WCFNavigationPropertyMapping.Lib.Configuration
{
public static class AutoMapperConfiguration
{
    public static void Configure()
    {
        AutoMapper.Mapper.AllowNullDestinationValues = false;
        Mapper.CreateMap<EntityFrameworkModel.League, Contracts.DataContracts.League>();
        Mapper.CreateMap<EntityFrameworkModel.Team, Contracts.DataContracts.Team>();
        Mapper.CreateMap<EntityFrameworkModel.Player, Contracts.DataContracts.Player>();
        Mapper.CreateMap<EntityFrameworkModel.League, Contracts.DataContracts.LeagueDTO>();
        Mapper.CreateMap<EntityFrameworkModel.Team, Contracts.DataContracts.TeamDTO>();
        Mapper.CreateMap<EntityFrameworkModel.Player, Contracts.DataContracts.PlayerDTO>();
    }
}
}
