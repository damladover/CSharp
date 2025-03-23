//class oluşturma 




namespace consoleApp{
    class Program{
        static void Main(string[] args){
            
            
            
            Ogrenci ogr1=new Ogrenci(){AdSoyad= "Damla döver",OgrenciNo="22",Sube="2"};
            Ogrenci ogr2=new Ogrenci(){AdSoyad= "ayşe",OgrenciNo="21",Sube="25"};
            Ogrenci ogr3=new Ogrenci(){AdSoyad= "fatma",OgrenciNo="3",Sube="24"};
            // ogr1.AdSoyad="DamlaDöver";
            // ogr1.OgrenciNo="220709075";
            // ogr1.Sube="2000";
            Ogrenci[] ogrenciler =new Ogrenci[3] {ogr1,ogr2,ogr3};
            ogr1.BilgileriYazdir();            foreach(var ogrenci in ogrenciler){
                ogrenci.BilgileriYazdir();

                  }





        }
    } 
    class Ogrenci{
       
       //prop yaz enter a bas
       public string OgrenciNo{get ;set;}
       public string AdSoyad{get; set;}
       public string Sube {get; set;}



       public void BilgileriYazdir()
       {
        Console.WriteLine($"{this.OgrenciNo}nolu {this.Sube}şubeli {this.AdSoyad} ");
            //return de kullanılabilir
       }
       
       
       
    }
}


