﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleApi.DAL;

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackingController : GitFitController
    {
        protected IProfileDAO profileDao;

        public TrackingController (IUserDAO userDao, IProfileDAO profileDao):base (userDao)
        {
            this.profileDao = profileDao;
        }

     
    }
}