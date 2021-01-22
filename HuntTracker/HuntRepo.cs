using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using HuntTracker.Models;

namespace HuntTracker
{
    public class HuntRepo : IHuntRepo

    {
        private readonly IDbConnection _conn;
        public HuntRepo(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Hunt> GetAllHunts()
        {
            return _conn.Query<Hunt>("SELECT * FROM HUNT_TRACKER.HUNTS;");


        }

        public Hunt GetHunt(int id)
        {
            return _conn.QuerySingle<Hunt>("SELECT * FROM HUNT_TRACKER.HUNTS WHERE HUNTID = @id",
                new { id = id });

        }

       public void InsertHunt(Hunt huntToInsert)
        {
            _conn.Execute("INSERT INTO HUNTS (DATE, TIMEOFSTART, TIMEOFEND, SEASON, WEATHER, USEDSCENTCONTROL, NUMBEROFDOES, NUMBEROFBUCKS, HARVESTED, TREESTANDLOCATION) " +
                "VALUES (@date, @timeofstart, @timeofend, @season, @weather, @usedscentcontrol, @numberofdoes, @numberofbucks, @harvested, @treestandlocation);",
                    new { Date = huntToInsert.Date, TimeOfStart = huntToInsert.TimeOfStart, TimeOfEnd = huntToInsert.TimeOfEnd, Season = huntToInsert.Season, Weather = huntToInsert.Weather,
                        UsedScentControl = huntToInsert.UsedScentControl, NumberOfDoes = huntToInsert.NumberOfDoes, NumberOfBucks = huntToInsert.NumberOfBucks, Harvested = huntToInsert.Harvested,
                        TreeStandLocation = huntToInsert.TreeStandLocation });
                    
        }

        public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM categories;");
        }

        public Hunt AssignCategory()
        {
            var categoryList = GetCategories();
            var hunt = new Hunt();
            hunt.Categories = categoryList;

            return hunt;
        }

    }


}
