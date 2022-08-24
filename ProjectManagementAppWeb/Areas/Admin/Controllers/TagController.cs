using Microsoft.AspNetCore.Mvc;
using ProjectManagementApp.DataAccess.Repository.IRepository;
using ProjectManagementApp.Models;

namespace ProjectManagementAppWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TagController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        //Constructor
        public TagController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        public IActionResult Index()
        {
            IEnumerable<Tag> objTagList = _unitOfWork.Tag.GetAll();
            return View(objTagList);
        }


        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tag obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Tag.Add(obj);
                _unitOfWork.Save();
                //TempData["success"] = "Category successfully created!";
                return RedirectToAction("Index");
            }
            return View(obj);
        }


    }
}
