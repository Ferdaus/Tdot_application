using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tdot_application.Models;
using Tdot_application.ViewModels;

namespace Tdot_application.Controllers
{
    public class ProjectController : Controller
    {
        private ApplicationDbContext _context;

        public ProjectController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Project/TestView
        public ActionResult TestView()
        {
            var project = new Project() 
            { CRS = "Knox Co 1-40 MM 377" ,
            StartDate = new DateTime(219, 10, 01),
            Analyst = "Joseph",
            //VolumeDataType ="AADT",
            AadtValue = 10,

            }; 
            return View(project);
        }

        public ActionResult Edit(int id)
        {

            return Content("id :"+ id);
        }

        /*public ActionResult Index(int? pageIndex, string sortBy)
        {
            return Content("");
        } */

        public ViewResult Index()
        {
            var projects = _context.Projects.Include(p => p.TerrainType).Include(p => p.HourlyDistributionType).ToList();
            
            return View(projects);
        }

        public ActionResult Details(int id)
        {
            var project = _context.Projects.SingleOrDefault(c => c.Id == id);

            if (project == null)
                return HttpNotFound();

            return View(project);
        }

        [Route("project/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Random()
        {
            var project = new Project() { CRS = "Knox Co 1-40 MM 377" };

            var estimatedHourlyVolume = new List<EstimatedHourlyVolume>
            {
                new EstimatedHourlyVolume { HourOne = 893},
                new EstimatedHourlyVolume { HourOne = 993},
                new EstimatedHourlyVolume { HourOne = 1093},

            };

            var viewModel = new ProjectAndVolumeDataViewModel
            {
                Project = project,
                EstimatedHourlyVolumes = estimatedHourlyVolume
            };

            return View(viewModel);
            //return View(movie);
            //return new ViewResult();
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        /*
        private IEnumerable<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project {Id =1, CRS = "Knox Co 1-40 MM 377"},
                new Project {Id =2, CRS = "Nash Co 1-46 MM 567"}

            };

        } 
        */
    }
}