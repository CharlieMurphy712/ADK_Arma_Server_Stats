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


                //return db.account.ToList<account>();
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

        public static List<account> GetKarma()
        {
            using (exile_tavianaEntities db = new exile_tavianaEntities())
            {
                return (from d in db.accounts
                        orderby d.karma descending
                        select d).ToList<account>();

                //return db.account.ToList<account>();
            }
        }

        public static List<account> GetMoney()
        {
            using (exile_tavianaEntities db = new exile_tavianaEntities())
            {
                return (from d in db.accounts
                        orderby d.money descending
                        select d).ToList<account>();

                //return db.account.ToList<account>();
            }
        }

        public static List<account> GetJoined()
        {
            using (exile_tavianaEntities db = new exile_tavianaEntities())
            {
                return (from d in db.accounts
                        orderby d.first_connect_at descending
                        select d).ToList<account>();

                //return db.account.ToList<account>();
            }
        }
    }

}