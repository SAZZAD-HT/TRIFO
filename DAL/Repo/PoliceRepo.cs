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
    internal class PoliceRepo : Irepo<Police, int, Police>
    {
        public Police add(Police obj)
        {
            throw new NotImplementedException();
        }

        public object add(Group converted)
        {
            throw new NotImplementedException();
        }

        public Police Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Police> get()
        {
            throw new NotImplementedException();
        }

        public Police get(int id)
        {
            throw new NotImplementedException();
        }

        public Police Update(Police obj)
        {
            throw new NotImplementedException();
        }
    }
}
