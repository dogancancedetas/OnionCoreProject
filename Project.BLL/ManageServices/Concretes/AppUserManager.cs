using Project.BLL.ManageServices.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManageServices.Concretes
{
    public class AppUserManager: BaseManager<AppUser>, IAppUserManager
    {
        IAppUserRepository _appRep;

        public AppUserManager(IAppUserRepository appRep): base(appRep)
        {
            _appRep = appRep;
        }
    }
}
