using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using HuntTracker.Models;

namespace HuntTracker
{
    public class HuntRepo : IHuntRepo
    {
        private readonly IDbConnection _conn;
        public IEnumerable<Hunt> GetAllHunts()
        {
            throw new NotImplementedException();


        }
    }
}
