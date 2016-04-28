using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanilla.Service.ViewModel;

namespace Vanilla.Service.Interface
{
    public interface IAccountService
    {
        UserView GetUserInfoBy(Guid id);
    }
}
