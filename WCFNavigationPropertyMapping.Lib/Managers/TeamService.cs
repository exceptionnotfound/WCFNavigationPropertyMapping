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
            try
            {
                var team = _context.Teams.Where(x => x.Id == id).AddIncludeStatements(options).First();
                var teamDTO = Mapper.Map<TeamDTO>(team);
                return teamDTO;
            }
            catch(Exception ex)
            {
                var exception = ex.ToString();
                return new TeamDTO();
            }
        }
    }
}
