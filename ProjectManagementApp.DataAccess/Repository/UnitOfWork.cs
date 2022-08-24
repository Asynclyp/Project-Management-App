using ProjectManagementApp.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementApp.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDBContext _db;
       

        //Constructor
        public UnitOfWork(ApplicationDBContext db)
        {
            _db = db;
            Tag = new TagRepository(_db);
        }

        public ITagRepository Tag { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
