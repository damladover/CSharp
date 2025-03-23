using(StreamReader sr =File.OpenText("deneme.txt"));

Console.WriteLine(sr.ReadLine());


StreamReader sr2 =File.OpenText("deneme.txt");
var s="";
while ((s=sr2.ReadLine()) != null)//boşluğa kadar olan elemanları listeler
Console.WriteLine(sr2.ReadLine());


string [] sonuc=File.ReadAllLines("deneme.txt");
Console.WriteLine(sonuc[0]);
Console.WriteLine(sonuc[2]); // 0 ve 2. elemanı listeler



using (StreamWriter sw = File.CreateText("deneme.txt"))
{
    sw.WriteLine("MERHABA");
    sw.WriteLine("BTK akademi");
    sw.WriteLine("damla");
    // close() yerine using yazıpparanteze alınabilir;
    //listeyi silip eklediklerini yazar;
}

using (StreamWriter sw = File.AppendText("deneme.txt"))
{
    sw.WriteLine("selam");
    sw.WriteLine("BTK");
    sw.WriteLine("Akademi1");
    sw.WriteLine("hello");

}
