using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace VillageRun
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery", "https://ajax.googleapis.com/ajax/libs/jquery/2.1.4/jquery.min.js")
                .Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap", "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js")
                .Include("~/Scripts/bootstrap.js","~/Scripts/respond.js"));
            bundles.Add(new StyleBundle("~/Content/bootstrap", "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css")
                .Include("~/Content/bootstrap.css"));
            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/Style.css"));

            BundleTable.EnableOptimizations = true;
            bundles.UseCdn = true;
        }
    }


}