using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Vanilla.Model;
using Vanilla.Repository.EF;
using Vanilla.Service.Implementation;
using Vanilla.Service.Interface;

namespace Vanilla.Infrastructure.Web
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController)ninjectKernel.Get(controllerType);
        }
        private void AddBindings()
        {
            ninjectKernel.Bind<IFolderRepository>().To<FolderRepository>();
            ninjectKernel.Bind<IFolderService>().To<FolderService>();

            ninjectKernel.Bind<IItemRepository>().To<ItemRepository>();
            ninjectKernel.Bind<IItemService>().To<ItemService>();
        }
    }
}