using System.Diagnostics;

//System.Diagnostics kütüphanesinde bulunan “Stopwatch” sınıfıyla kodlarımızın çalışma sürelerini hızlı bir şekilde bulup, istediğimiz formatta değerlendirebiliyoruz.

Stopwatch SureHesapla = new Stopwatch();

SureHesapla.Start();

Thread.Sleep(9000);

SureHesapla.Stop();

TimeSpan HesaplananZaman = SureHesapla.Elapsed;
string Sonuc = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
HesaplananZaman.Hours, HesaplananZaman.Minutes, HesaplananZaman.Seconds, HesaplananZaman.Milliseconds / 10);
Console.WriteLine(Sonuc);