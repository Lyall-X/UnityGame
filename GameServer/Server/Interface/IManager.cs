using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Interface
{
    public interface IManager : IObject
    {
        void Initialize();
        void OnDispose();
    }
}
