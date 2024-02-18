// Soru 1: Aşağıdaki belirtilen liste adındaki integer dizisinde bulunan; 3 den büyük 500 den küçük tek sayıları filtreleyerek, küçükten büyüğe doğru sıralama yapan linq sorgusunu yazınız.

using System.ComponentModel.Design;

var liste = new int[] {1,3,15,18,33,44,56,101,125,168,321,432,321,522};
 var SonucListe = liste
    .Where(x => x > 3 && x < 500 && x % 2 == 1)
    .OrderBy(x => x)
    .ToArray();
        
    foreach (var sayi in SonucListe)
    {
        Console.WriteLine(sayi);
     }

     
// Soru 2 : Yıldızlar ile şekildeki 10 katlı piramidi oluşturan kod bloğunu yazınız.
int n = 10;
for(int i = 1; i<=n; i++)
{
    for(int j = 1; j<=(n-i); j++)
    {
        Console.Write(" ");
    }
for(int k = 1; k<=((2*i)-1); k++)
{
    Console.Write("*");
}
Console.WriteLine();
}

// Soru 3 : Son 7 gün içinde "Roman" türündeki kitapları okuyan öğrencilerin numarasını,adını,soyadını ve okuduğu kitabın yazarını listeleyen sql sorgusunu yazınız.

SELECT o.ogrno, o.ograd, o.ogrsoyad, k.isbnno, y.yazarad, y.yazarsoyad
FROM ogrenci o
JOIN islem i ON o.ogrno = i.ogrno
JOIN kitap k ON i.kitapno = k.kitapno
JOIN yazar y ON k.yazarno = y.yazarno
JOIN tur t ON k.turno = t.turno
WHERE t.turadi = 'Roman' AND i.vtarih >= (SELECT DATE('now', '-7 day'));

// Soru 4 : Aşağıda belirtilen Javascript kodunun console'a yazacağı değerleri doğru sırayla yazınız. Bu soru javascript kod akışı ve zamanlamasıyla ilgili bilginizi ölçecektir.
(function(){
console.log(1);
setTimeout(function(){console.log(2)},1000);
setTimeout(function(){console.log(3)},0);
console.log(4);
})();

// Yazdırılan değerlerin sırasıyla "1", "4", "3", "2"  olması beklenir.
// Önce console.log(1)
// Daha sonra console.log(4) yazdırılır ve çalışır ve daha sonra setTimeout fonksiyonları çalışmaya başlar.
// console.log(3) 0. saniye olduğu için üçüncü olarak bu değer yazdırılır.
// console.log(2) 1 saniye sonra olduğu için dördüncü olarak bu değer yazdırılır.



// Soru 5 : String ve StringBuilder arasındaki farklar nelerdir?

//String sınıfında değişiklik olmazken StringBuilder değiştirilebilir bir sınıftır.
//StringBuilder doğrudan değişiklik yapılabildiği için performans bakımından daha etkilidir.
//String sınıfı senkronize olduğu için daha güvenilirdir. StringBuilder senkronize değildir.


//Soru 6 : Restful ve Soap web servisleri arasındaki farklar nelerdir?
// Restful HTTP üzerinde bir protokolü temel alırken, Soap XML tabanlıdır ve HTTP,SMTP,TCP,UDP üzerinde çalışabilir.
// Restful JSON yaygın olarak tercih edilir, Soap genellikle XML formatında veri alışverişi yapar.
// Restful hataları HTTP kodları ile ifade eder. Soap ise XML öğesi içinde tanımlar.

//Soru 7 : Browser tarafından bir adres çağrıldığında arka tarafta yapılan işlemleri sıralayınız.

// DNS Çözümleme
// TCP Bağlantısı
// HTTP isteği
// Host işleme
// Browser İçerik Gösterme
// Kaynak İndirme
// Kullanıcı

//Soru 8 : Polymorphism nedir ?

// Nesne yönelimi programlamada kullanılan, bir nesnenin farklı şekillerde davranabilme yeteneğini ifade eden bir programlama konseptidir.

// Soru 9 : Struct ve Class arasındaki farklar nelerdir?

// Struct genellikle public, Class genellikle privatedir.
// Struct Inheritance desteklemez, Class destekler.(Farklı dillerde değişiyor sanırım)
// Struct cons ve dest desteklenmez, Class destekler.

// Soru 10 : Razor View Engine kavramı nedir?
// .Net web uygulamada kullanılan bir görünüm motorudur. Web uygulama mimarilerinde kullanılmaktadır.
