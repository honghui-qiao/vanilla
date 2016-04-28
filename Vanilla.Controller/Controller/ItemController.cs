using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Vanilla.Service;
using Vanilla.Service.Interface;
using Vanilla.Service.ViewModel;

namespace Vanilla.Controller
{
    public class ItemController : System.Web.Mvc.Controller
    {
        private IItemService _itemService;
        public ItemController(IItemService service)
        {
            _itemService = service;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit(ItemView item)
        {
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            return View();
        }

        // Get
        public ActionResult Create()
        {
            ItemCreationVM vm = new ItemCreationVM();
            List<FolderView> fvs = new List<FolderView>();
            fvs.Add(new FolderView { Id = 1, FolderName = "Folder One" });
            vm.Folders = new SelectList(fvs, "Id", "FolderName");
            return View(vm);
        }

        // Post
        [HttpPost]
        public ActionResult Create(ItemCreationVM item)
        {
            if (ModelState.IsValid)
            {
                _itemService.AddItem(new ItemView
                {
                    Title = item.Title,
                    Description = item.Abstract,
                    Body = item.Body
                });
                return RedirectToAction("Index", "Home");
            }
            return View(item);
        }

        public ActionResult ItemList(int fid = 0)
        {
            ItemListViewModel vm = new ItemListViewModel();

            vm.Items = _itemService.GetAllItems();
            return PartialView("_ItemListPartial", vm);
        }
    }
}
