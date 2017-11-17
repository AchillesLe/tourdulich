using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace BIZ
{
    public class cttqBIZ
    {
        public IRepository<ctthamquan> cttq;
        public Dictionary<string, string> validatedictionary = new Dictionary<string, string>();
        public cttqBIZ()
        {
            cttq = new GenericRepository<ctthamquan>();
        }

        public List<cttqdto> listdanhsachthamquan(int value)
        {
            return cttq.Find(c => c.idtour == value).Select(c => new cttqdto(c)).ToList();
        }
    }
}
