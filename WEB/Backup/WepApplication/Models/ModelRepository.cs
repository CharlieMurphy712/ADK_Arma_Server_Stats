using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WepApplication.Models
{
    public class ModelRepository
    {
        public static List<account> GetHighestDeaths()
        {
            using (exile_tavianaEntities db = new exile_tavianaEntities())
            {

                return (from d in db.accounts
                        orderby d.deaths descending
                        select d).ToList<account>();


                //return db.account.FirstOrDefault(d => d.AutoID == 1);
            }
        }

        public static List<account> GetItemSet()
        {
            using (exile_tavianaEntities db = new exile_tavianaEntities())
            {
                return (from d in db.accounts
                        orderby d.kills descending
                        select d).ToList<account>();

                //return db.account.ToList<account>();
            }
        }
    }

}