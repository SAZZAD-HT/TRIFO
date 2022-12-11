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
    internal class CaseRepo : Irepo<Case, int, Case>
    {
        TrifoEntities db;
        internal CaseRepo()
        {
            db = new TrifoEntities();
        }

        public Case add(Case obj)
        {

            db.Cases.Add(obj);
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

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Case> get()
        {
            return db.Cases.ToList();
        }

        public Case get(int id)
        {
            return db.Cases.Find(id);
        }

        public Case Update(Case obj)
        {
            var dbobbj = db.Cases.Find(obj.Case_id);
            db.Entry(dbobbj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        Case Irepo<Case, int, Case>.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
