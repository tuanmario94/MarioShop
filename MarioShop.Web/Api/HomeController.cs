using MarioShop.Service;
using MarioShop.Web.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MarioShop.Web.Api
{
    [RoutePrefix("api/home")]
    [Authorize(Roles = "LoginAdminPage")]
    public class HomeController : ApiControllerBase
    {
        IErrorService _errorService;
        public HomeController(IErrorService errorService) : base(errorService)
        {
            this._errorService = errorService;
        }


    }
}
