using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Infratructure.IRepositories
{
    public interface IUnitOfWork
    {
        bool Commit();
        void Dispose();
    }
}
