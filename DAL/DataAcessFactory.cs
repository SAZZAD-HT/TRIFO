using DAL.DB;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAcessFactory
    {
        public static Irepo<ADMIN, int, ADMIN> AdminDataAcess()
        {
            return new ADMINRepo();
        }
        public static Irepo<BUS, int, BUS> BusDataAcess()
        {
            return new BusRepo();
        }
        public static Irepo<Case, int,Case> CaseDataAcess()
        {
            return new CaseRepo();
        }
        public static Irepo<Fare, int, Fare> FareDataAcess()
        {
            return new FareRepo();
        }
        public static Irepo<Police, int, Police> PoliceDataAcess()
        {
            return new PoliceRepo();
        }


    }
}
