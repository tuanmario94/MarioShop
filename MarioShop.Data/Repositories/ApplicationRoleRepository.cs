﻿using MarioShop.Data.Infrastructure;
using MarioShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioShop.Data.Repositories
{
    public interface IApplicationRoleRepository : IRepository<ApplicationRole>
    {
        IEnumerable<ApplicationRole> GetListRoleByGroupId(int groupId);
    }
    public class ApplicationRoleRepository : RepositoryBase<ApplicationRole>, IApplicationRoleRepository
    {
        public ApplicationRoleRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
        public IEnumerable<ApplicationRole> GetListRoleByGroupId(int groupId)
        {
            var query = from g in DbContext.ApplicationRoles
                        join ug in DbContext.ApplicationRoleGroups
                        on g.Id equals ug.RoleId
                        where ug.GroupId == groupId
                        select g;
            return query;
        }
    }
}
