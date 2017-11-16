using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace BIZ
{
    public class DiaDiemBIZ
    {
        public IRepository<diadiem> diadiem;
        public Dictionary<string, string> validatedictionary = new Dictionary<string, string>();
        public DiaDiemBIZ()
        {
            diadiem = new GenericRepository<diadiem>();
        }
        public bool add(diadiem entity)
        {
            return diadiem.Add(entity);
        }
        public bool update(diadiem entity)
        {
            return diadiem.Attach(entity);
        }
        public List<diadiemdto> list()
        {
            return diadiem.GetAll().Select(c => new diadiemdto(c)).ToList();
        }
        public int getcurrentid()
        {
            try { return diadiem.GetQuery().Count(); }
            catch { return 0; }
        }
        public bool find(string value, int value2)
        {
            var a = diadiem.Find(c => c.tendiadiem == value && c.idtinh == value2).ToList();
            if (a.Count > 0)
                return false;
            return true;
        }
    }
}
