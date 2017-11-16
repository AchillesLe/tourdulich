using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace BIZ
{
    public class LoaiTourBIZ
    {
        public IRepository<loaitour> loaitour;
        public Dictionary<string, string> validatedictionary = new Dictionary<string, string>();
        public LoaiTourBIZ()
        {
            loaitour = new GenericRepository<loaitour>();
        }
        public bool add(loaitour entity)
        {
                return loaitour.Add(entity);
        }
        public bool update(loaitour entity)
        {
                return loaitour.Attach(entity);
        }
        public List<loaitourdto> list()
        {
            return loaitour.GetAll().Select(c => new loaitourdto(c)).ToList();
        }
        public int getcurrentid()
        {
            try { return loaitour.GetQuery().Count(); }
            catch { return 0; }
        }
        public bool find(string value)
        {
            var a = loaitour.Find(c => c.tenloaitour == value).ToList();
            if(a.Count > 0 )
                return false;
            return true;
        }
    }
}
