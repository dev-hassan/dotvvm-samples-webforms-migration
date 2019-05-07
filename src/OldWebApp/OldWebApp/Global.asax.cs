﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace OldWebApp
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.MapPageRoute("Default", "", "~/Default.aspx");
            RouteTable.Routes.MapPageRoute("About", "About", "~/About.aspx");
            RouteTable.Routes.MapPageRoute("Contact", "Contact", "~/Contact.aspx");
        }
    }
}