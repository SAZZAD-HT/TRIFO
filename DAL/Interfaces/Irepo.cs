using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface Irepo<CLASS, ID, RES>
    {
        List<CLASS> get();
        CLASS get(ID id);
        RES add(CLASS obj);
       RES Delete(ID id);
     RES  Update(CLASS obj);
        object add(Group converted);
    }
}
