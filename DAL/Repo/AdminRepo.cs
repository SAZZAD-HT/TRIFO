using DAL.DB;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class ADMINRepo : Irepo<ADMIN, int, ADMIN>
    {
        TrifoEntities db;
        internal ADMINRepo()
        {
            db = new TrifoEntities();
        }

        public ADMIN add(ADMIN obj)
        {
            db.ADMINs.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public object add(Group converted)
        {
            throw new NotImplementedException();
        }

        public ADMIN Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ADMIN> get()
        {
            return db.ADMINs.ToList();
        }

        public ADMIN get(int id)
        {
            return db.ADMINs.Find(id);
        }

        public ADMIN Update(ADMIN obj)
        {
            var dbobbj = db.ADMINs.Find(obj.Admin_ID);
            db.Entry(dbobbj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
