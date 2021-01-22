using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HuntTracker.Models;

namespace HuntTracker
{
    public interface IHuntRepo
    {
        public IEnumerable<Hunt> GetAllHunts();
        public Hunt GetHunt(int id);
        public void InsertHunt(Hunt huntToInsert);
        public IEnumerable<Category> GetCategories();
        public Hunt AssignCategory();

    }
}

