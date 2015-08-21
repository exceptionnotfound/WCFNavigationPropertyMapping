using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFNavigationPropertyMapping.Contracts.DataContracts;
using WCFNavigationPropertyMapping.Contracts.Options;
using WCFNavigationPropertyMapping.Lib.EntityFrameworkModel;
using WCFNavigationPropertyMapping.Lib.Extensions;

namespace WCFNavigationPropertyMapping.Lib.Managers
{
    public class TeamService
    {
        private LeaguesDataContext _context;

        public TeamService()
        {
            _context = new LeaguesDataContext();
        }

        public TeamDTO GetByID(int id, TeamOptions options)
        {
            return Mapper.Map<TeamDTO>(_context.Teams.Where(x => x.Id == id).AddIncludeStatements(options).First());
        }
    }
}
