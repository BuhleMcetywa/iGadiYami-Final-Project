using IGadiYami.Models.UserInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.Interface
{
    public interface IService
    {
        void Save(UserDetails signup);
    }
}
