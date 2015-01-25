using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTProje.UI.Model.Models;

namespace VTProje.Business
{
    public static class DBIslemleri
    {
        static KitapciDBContext context;
        private static KitapciDBContext GetContext()
        {
            if (context == null)
                context = new KitapciDBContext();
            return context;
        }

        public static bool MusteriKontrol(int mid)
        {
            context = GetContext();
            return context.musteris.Where(m => m.mid == mid).Count() > 0;

        }
        public static void MusteriEkle(musteri m)
        {
            context = GetContext();
            context.musteris.Add(m);
            context.SaveChanges();
        }
        public static void MusteriEkle(onlineMusteri m)
        {
            context = GetContext();
            context.onlineMusteris.Add(m);
            context.SaveChanges();
        }
        public static void MusteriEkle(magazaMusteri m)
        {
            context = GetContext();
            context.magazaMusteris.Add(m);
            context.SaveChanges();
        }
        public static string MusteriDuzenle(int mid, object musteri)
        {
            if (MusteriKontrol(mid))
            {
                if (mid % 2 == 1)
                {
                    onlineMusteri n = (onlineMusteri)musteri;
                    onlineMusteri o = (onlineMusteri)MusteriGetir(mid);
                    o.email = n.email;
                    o.szt = n.szt;

                }
                else
                {

                    magazaMusteri n = (magazaMusteri)musteri;
                    magazaMusteri o = (magazaMusteri)MusteriGetir(mid);
                    o.telNo = n.telNo;
                }
                context.SaveChanges();
                return "Güncelleme başarıyla yapıldı";
            }
            return "Güncelleme yapılamadı, Müşteri bulunamadı";
        }
        public static string MusteriSil(int mid)
        {
            if (MusteriKontrol(mid))
            {
                if (mid % 2 == 1)
                {
                    onlineMusteri o = (onlineMusteri)MusteriGetir(mid);
                    context.onlineMusteris.Remove(o);

                }
                else
                {

                    magazaMusteri o = (magazaMusteri)MusteriGetir(mid);
                    context.magazaMusteris.Remove(o);
                }
                musteri m = context.musteris.Where(x => x.mid == mid).First();
                context.musteris.Remove(m);

                context.SaveChanges();
                return "Silme işlemi başarıyla yapıldı";
            }
            return "Silme yapılamadı, Müşteri bulunamadı";
        }
        public static object MusteriGetir(int mid)
        {
            context = GetContext();
            if (mid % 2 == 1)
                return context.onlineMusteris.Where(m => m.mid == mid).FirstOrDefault();
            else
                return context.magazaMusteris.Where(m => m.mid == mid).FirstOrDefault();

        }
        public static bool SiparisKontrol(int sid)
        {
            return context.siparislers.Where(m => m.siparisNo == sid).Count() > 0;

        }
        public static string SiparisEkle(siparisler s, kitap k)
        {
            context = GetContext();
            if (MusteriKontrol(s.musteriNo))
            {
                context.siparislers.Add(s);

                context.kitaps.Add(k);
                context.SaveChanges();
                return "Sipariş eklendi.";
            }
            else
                return "Bu ID'de müşteri yok.";
        }
        public static siparisler SiparisGetir(int sid)
        {
            context = GetContext();
            return context.siparislers.Where(m => m.siparisNo == sid).FirstOrDefault();

        }
        public static kitap KitapGetir(int sid)
        {
            context = GetContext();
            return context.kitaps.Where(m => m.sipNo == sid).First();

        }
        public static List<fatura> FaturaGetir(int sid)
        {
            return context.faturas.Where(m => m.sipNo == sid).ToList();
        }
        public static List<fatura> FaturaGetirByMusteri(int mid)
        {
            context = GetContext();
            decimal borc = context.kitaps.Where(k => k.siparisler.musteriNo == mid).Sum(a => a.miktar * a.birimFiyat);
            //context.faturas.Where(x => x.odemelers.Where(y => y.odemeMiktari < borc) && x.siparisler.musteriNo == mid).ToList();
            List<fatura> faturas = context.faturas.Where(x => x.siparisler.musteriNo == mid).ToList();
           
            List<odemeler> odemee = context.odemelers.Where(x => x.fatura.siparisler.musteriNo == mid && x.odemeMiktari < borc).ToList();

            List<fatura> faturalar = new List<fatura>();
            foreach (fatura item in faturas)
            {

                if (item.odemelers.Count ==0 || item.odemelers.Where(y => y.odemeMiktari < borc).Count() > 0)
                    faturalar.Add(item);
             
            }
            return faturalar;
        }
        public static List<fatura> FaturaGetirBySiparis(int sid)
        {
            List<odemeler> odemee = context.odemelers.Where(x => x.odemeMiktari > 0 && x.fatura.siparisler.siparisNo == sid).ToList();
            List<fatura> faturalar = new List<fatura>();
            foreach (odemeler item in odemee)
            {
                faturalar.Add(item.fatura);
            }
            return faturalar;
        }
        public static string FaturaEkle(fatura f)
        {
            try
            {
                context = GetContext();
                context.faturas.Add(f);
                context.SaveChanges();
                return "Fature eklendi";
            }
            catch
            {
                return "Fatura eklenemedi";
            }
        }
        public static string SiparisSil(int sid)
        {
            siparisler si = SiparisGetir(sid);
            if (si.faturas.Count() > 0)
                return "Bu sipariş iptal edilemez, Fatura kesilmiş";

            context.siparislers.Remove(si);
            context.SaveChanges();

            return "Sipariş iptal edildi";

        }
        public static string SiparisDuzenle(siparisler si, kitap ki)
        {
            if (MusteriKontrol(si.musteriNo))
            {
                if (SiparisKontrol(si.siparisNo))
                {
                    siparisler s = SiparisGetir(si.siparisNo);

                    s.musteriNo = si.musteriNo;
                    s.tarih = si.tarih;

                    kitap k = KitapGetir(si.siparisNo);
                    k.miktar = ki.miktar;
                    k.hangiDepo = ki.hangiDepo;
                    k.adi = ki.adi;
                    k.birimFiyat = ki.birimFiyat;

                    context.SaveChanges();
                    return "Sipariş başarıyla güncellendi";
                }
                return si.siparisNo + " Numaralı sipariş bulunamadı";
            }
            else
                return "Müşteri bulunamadı";

        }
    }
}
