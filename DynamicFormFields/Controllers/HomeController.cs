using System.Linq;
using DynamicFormFields.Models;
using DynamicFormFields.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DynamicFormFields.Controllers
{
    public class HomeController : Controller
    {
        private readonly DynamicFieldRepository _dynamicFieldRepository;
        private readonly ItemRepository _itemRepository;

        public HomeController()
        {
            _dynamicFieldRepository = new DynamicFieldRepository();
            _itemRepository = new ItemRepository();
        }

        public IActionResult Index()
        {
            var items = _itemRepository.GetItems();

            var model = new ItemForm
            {
                ExtraFields = new DynamicFieldWrapper
                {
                    ModelNodePrefix = nameof(ItemForm.ExtraFields),
                    Items = _dynamicFieldRepository.GetFieldsByItem(items.First().Id)
                },
                ItemNames = items.Select(x => new SelectListItem(x.Name, x.Id.ToString()))
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ItemForm model)
        {
            return Json(model);
        }

        [HttpGet]
        public IActionResult GetFieldsForProvider(int itemId, string nodePrefix)
        {
            var model = new DynamicFieldWrapper
            {
                ModelNodePrefix = nodePrefix,
                Items = _dynamicFieldRepository.GetFieldsByItem(itemId)
            };
            return PartialView("_DynamicFields", model);
        }
    }
}
