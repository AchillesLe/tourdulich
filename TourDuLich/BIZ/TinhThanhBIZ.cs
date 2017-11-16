using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace BIZ
{
    public class TinhThanhBIZ
    {
        public IRepository<tinh> tinhrp;
        public Dictionary<string, string> validatedictionary = new Dictionary<string, string>();
        public TinhThanhBIZ()
        {
            tinhrp = new GenericRepository<tinh>();
        }
        public bool add(tinh entity)
        {
            return tinhrp.Add(entity);
        }
        public bool update(tinh entity)
        {
            return tinhrp.Attach(entity);
        }
        public List<tinhdto> list()
        {
            return tinhrp.GetAll().Select(c => new tinhdto(c)).ToList();
        }
        public int getcurrentid()
        {
            try { return tinhrp.GetQuery().Count(); }
            catch { return 0; }
        }
        public bool find(string value)
        {
            var a = tinhrp.Find(c => c.tentinh == value).ToList();
            if (a.Count > 0)
                return false;
            return true;
        }
        public List<string> danhsachtinh()
        {
            return tinhrp.GetAll().Select(c => c.tentinh).Distinct().ToList();
        }
        public int laymatinh(string value)
        {
            return tinhrp.Find(c => c.tentinh == value).FirstOrDefault().id;
        }
    }
}
