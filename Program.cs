using System;
namespace sinif_kavrami
{
    class program
    {
        static void Main(string []args)
        {
            çalışan user1 =new çalışan("Muhammed","Solmaz",25887915,"IT");
            çalışan user2=new çalışan("İkbal","Kıyatsıl",15996315,"Muhasebe");
            

            user1.çalışanBilgileriYazdırma();
            Console.WriteLine("*********************");
            user2.çalışanBilgileriYazdırma();
        }
    }    
    class çalışan
    {
        public string ad;
        public string soyad;
        public int no;
        public string departman;

        public çalışan(string _ad, string _soyad, int _no, string _departman)
        {
            this.ad=_ad;
            this.soyad=_soyad;
            this.no=_no;
            this.departman=_departman;
        }
        public çalışan()
        {}
        public void çalışanBilgileriYazdırma()
        {
            Console.WriteLine("Çalışanın adı: "+ ad);
            Console.WriteLine("Çalışanın soyadı: "+soyad);
            Console.WriteLine("Çalışanın numarası: "+no);
            Console.WriteLine("Çalışanın departmanı: "+departman);
        }
    }
}