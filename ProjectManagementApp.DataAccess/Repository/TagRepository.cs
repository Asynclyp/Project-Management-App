using ProjectManagementApp.DataAccess.Repository.IRepository;
using ProjectManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementApp.DataAccess.Repository
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {

        private readonly ApplicationDBContext _db;

        //Constructor
        public TagRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Tag obj)
        {
            _db.Tags.Update(obj);
        }

    }
}
