using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.DTO
{
    public class CaseDto
    {
        public int Case_id { get; set; }
        public int P_id { get; set; }
        public string P_rank { get; set; }
        public string Area { get; set; }
        public string Case_type { get; set; }
    }
}
