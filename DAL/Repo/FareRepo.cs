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
    internal class FareRepo : Irepo<Fare, int, Fare>
    {
        public Fare add(Fare obj)
        {
            throw new NotImplementedException();
        }

        public object add(Group converted)
        {
            throw new NotImplementedException();
        }

        public Fare Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Fare> get()
        {
            throw new NotImplementedException();
        }

        public Fare get(int id)
        {
            throw new NotImplementedException();
        }

        public Fare Update(Fare obj)
        {
            throw new NotImplementedException();
        }
    }
}
