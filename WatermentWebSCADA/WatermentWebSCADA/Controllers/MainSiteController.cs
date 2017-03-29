﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using WatermentWebSCADA.Models;
using WatermentWebSCADA.ViewModels;
using System.Data;
using System.Data.Entity;
using System.Net;
using MySql.Data.MySqlClient;
using MySql.Data.Entity;
using System.Data.Common;
using System.Web.Helpers;
using WatermentWebSCADA.Models;

namespace WatermentWebSCADA.Controllers
{
    public class MainSiteController : Controller
    {
        Models.watermentdbEntities db = new Models.watermentdbEntities();
        
        // GET: Main
        public ActionResult Index(int? id)
        {
            using (var db1 = new Models.watermentdbEntities())
            {
                var model = new MainViewModel
                {
                    Alarmer = db.alarms.ToList(),
                    Anlegg = db.facilities.Where(c=>c.Id==id).ToList(),
                    Kontinenter = db.continents.ToList(),
                    Land = db.countries.ToList(),
                    Utstyr = db.equipments.ToList(),
                    Lokasjoner = db.locations.ToList(),
                    Vedlikehold = db.maintenance.ToList(),
                    Roller = db.roles.ToList(),
                    Brukere = db.users.ToList(),
                    Sesjoner = db.sessions.ToList(),
                 
                
    };

               
                return View(model);
        }
   }

        public ActionResult FacilityDetails(int? id)
        {
            int landid = 167;

            using (var db1 = new Models.watermentdbEntities())
            {
                var model = new MainViewModel
                {
                    Alarmer = db.alarms.ToList(),
                    Anlegg = db.facilities.Where(c => c.Id == id).ToList(),

                    //Anlegg2=db.facilities.Where(x=>x.locations_countries_Id=landid),

                    Kontinenter = db.continents.ToList(),

                    Land = db.countries.Where(x=>x.Id==landid).ToList(),
                    Utstyr = db.equipments.ToList(),
                    Lokasjoner = db.locations.ToList(),
                    Vedlikehold = db.maintenance.ToList(),
                    Roller = db.roles.ToList(),
                    Brukere = db.users.ToList(),
                    Sesjoner = db.sessions.ToList(),

                };

                return View(model);
            }
        }


    }
     
       

      
    }
