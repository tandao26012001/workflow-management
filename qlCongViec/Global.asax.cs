﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace qlCongViec
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            qlCongViec.CorsSupport.HandlePreflightRequest(HttpContext.Current);
        }

    }
}