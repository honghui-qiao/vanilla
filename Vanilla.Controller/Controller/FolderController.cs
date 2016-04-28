using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vanilla.Service;
using Vanilla.Service.ViewModel;

namespace Vanilla.Controller
{
    public class FolderController : System.Web.Mvc.Controller
    {
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(FolderView c)
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult FolderTree(int id = 0)
        {
            FolderTreeViewModel viewModel = new FolderTreeViewModel();
            viewModel.Folders.Add(new FolderView { Id = 1, FolderName = "JavaScript" });
            viewModel.Folders.Add(new FolderView { Id = 2, FolderName = "Java" });
            viewModel.Folders.Add(new FolderView { Id = 3, FolderName = "PHP" });
            viewModel.Folders.Add(new FolderView
            {
                Id = 4,
                FolderName = "C#",
                ChildFolders = new List<FolderView>
                {
                    new FolderView { ParentFolderId = 4, Id = 5, FolderName = "Web Form" },
                    new FolderView { ParentFolderId = 4, Id = 6, FolderName = "MVC" },
                    new FolderView { ParentFolderId = 4, Id = 7, FolderName = "Win Form" }
                }
            });
            viewModel.SelectedFolderId = 1;

            return PartialView("_FolderTreePartial", viewModel);
        }
    }
}
