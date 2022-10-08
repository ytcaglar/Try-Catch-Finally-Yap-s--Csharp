using System;

namespace trycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try // Hata alması muhtemel çalıştırılacak kod bloğu try içine yazılır.
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı : "+sayi);
            }
            catch(Exception ex) // Hatayı Burası Yakalar.
            {
                Console.WriteLine("Hata: "+ex.Message.ToString()); // Hata mesajını alıp onuda stringe çevirdik.
            }
            finally // Hata alsın almasın finally her türlü çalışacaktır. Zorunlu değildir.
            {   
                Console.WriteLine("İşlem tamamlandı.");
            }

            try
            {
                // int a = int.Parse(null);
                // int a = int.Parse("str");
                int a = int.Parse("22222222222222");
            }
            catch (ArgumentNullException ex) // Belirilen hata türünde hata yakalamak istenirse kullanılır.
                                    // Burada yakalamak istenilen hata türü boş değer olması.
            {
                
                Console.WriteLine("Boş değer girdiniz!");
                Console.WriteLine(ex);
            }
            catch(FormatException ex) // Verilen atamanın veri tipine uymamasıdır. int'a string vermek gibi.
            {
                Console.WriteLine("Veri tipi uygun değil!");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex) // Verilen veri tipinin sınırları dışında bir değer girilirse yakalar.
            {
                Console.WriteLine("İnteger veri tipinin sınırları dışında bir değer girdiniz!");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlanmıştır!");
            }
        }
    }
}

