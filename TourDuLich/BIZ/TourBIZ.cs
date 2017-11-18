using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
namespace BIZ
{
    public class TourBIZ
    {
        public IRepository<tour> tour;
        public Dictionary<string, string> validatedictionary = new Dictionary<string, string>();
        public TourBIZ()
        {
            tour = new GenericRepository<tour>();
        }

        public bool add(tour entity)
        {
            if (validate(entity))
                return tour.Add(entity);
            return false;
        }

        public bool update(tour entity)
        {
                return tour.Attach(entity);
        }

        public List<tourdto> list()
        {
            return tour.GetAll().Select(c => new tourdto(c)).ToList();
        }

        public List<string> danhsachtour()
        {
            return tour.GetAll().Select(c => c.tentour).Distinct().ToList();
        }

        public List<string> danhsachtour1()
        {
            return tour.GetAll().Select(c => c.tentour).ToList();
        }

        public List<tourdto> timtour(string value)
        {
            return tour.Find(c => c.tentour == value).Select(c => new tourdto(c)).ToList();
        }

        public int getcurrentid()
        {
            try { return tour.GetQuery().Count(); }
            catch { return 0; }
        }

        public int laymatour(string value)
        {
            return tour.Find(c => c.tentour == value).FirstOrDefault().id;
        }

        public bool find(string value)
        {
            var a = tour.Find(c => c.tentour == value).ToList();
            if (a.Count > 0)
                return false;
            return true;
        }

        public tour laytoursuagia(int value)
        {
            tour a = new tour();
            a = tour.Find(c => c.id == value).FirstOrDefault();
            return a;
        }

        public bool validate(tour entity)
        {
            if (entity.diemden == entity.diemdi) validatedictionary.Add("TENTOUR", "Điểm đến không thể giống điểm đi");
            if (entity.giatour == 0) validatedictionary.Add("GIATOUR", "Chưa nhập giá tour");
            if (validatedictionary.Count() <= 0)
                return true;
            return false;
        }


    }
}
