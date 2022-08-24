using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementApp.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ITagRepository Tag { get; }
        void Save();
    }



}
