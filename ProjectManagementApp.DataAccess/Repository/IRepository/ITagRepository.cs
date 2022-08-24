using ProjectManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementApp.DataAccess.Repository.IRepository
{
    public interface ITagRepository : IRepository<Tag>
    {
        void Update(Tag obj);
    }
}
