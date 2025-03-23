using System;
namespace consoleApp{
    class Program{
        static void Main(string[] args){
            var soru1 =new Soru() { 
            SoruMetni ="hangisi programlama dli değildir?",
            Secenekler= new string[]{"Python","c^#","Java","Html"},
            Cevap= "Html"

        };
            var soru2 =new Soru() { 
            SoruMetni ="hangisi popüler programlama dilidir?",
            Secenekler= new string[]{"Python","C#","Java","Html"},
            Cevap= "C#"
        };
        var soru3 =new Soru() { 
            SoruMetni ="hangisi popüler web platformu değildir?",
            Secenekler= new string[]{"Python","Django","Asp.Net","Spring"},
            Cevap= "Python"
        };
        var sorular = new Soru[]{soru1,soru2,soru3};
        foreach(var soru in sorular)
        {
            Console.WriteLine(soru.SoruMetni);
            foreach(var secenek in soru.Secenekler){
                Console.WriteLine(secenek);
            }
            Console.Write("cevabınız:");
            
            var cevap =Console.ReadLine();
            
            if(soru.cevapKontrol(cevap)){
                Console.WriteLine("doğru");
            
            }else {
                Console.WriteLine("yanlış");

            }

            }

        }
        }
    }
        class Soru {
            public string SoruMetni{ get ; set ; }
            public string[] Secenekler {get ; set;}
            public string Cevap { get; set;}
            
            
            public bool cevapKontrol( string cevap)
            {
                return this.Cevap.ToLower()==cevap.ToLower();
            }

        
        }
