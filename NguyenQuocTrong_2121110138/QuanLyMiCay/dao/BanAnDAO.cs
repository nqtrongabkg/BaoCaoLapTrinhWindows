using QuanLyMiCay.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMiCay.dao
{
    internal class BanAnDAO
    {
        private ChuoiKN _context;

        public BanAnDAO(ChuoiKN context)
        {
            _context = context;
        }

        public List<BanAn> LayTatCaBanAn()
        {
            return _context.BanAns.ToList();
        }

        public BanAn LayBanAnTheoId(int MaBanAn)
        {
            return _context.BanAns.Find(MaBanAn);
        }

        public void ThemBanAn(BanAn banAn)
        {
            _context.BanAns.Add(banAn);
            _context.SaveChanges();
        }

        public void CapNhatBanAn(BanAn banAn)
        {
            _context.Entry(banAn).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void XoaBanAn(int MaBanAn)
        {
            var banAn = _context.BanAns.Find(MaBanAn);
            if (banAn != null)
            {
                _context.BanAns.Remove(banAn);
                _context.SaveChanges();
            }
        }
    }
}







