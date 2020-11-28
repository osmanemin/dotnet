using System;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            int deneme = 10;
            char character = 'A';
            Console.WriteLine("Character is a {0}", (int)character);
            Console.WriteLine("sayi = {0}",deneme); 
            Console.WriteLine("Hello World!");
            Console.WriteLine((int)Days.Carsamba);

            Deneme denemelik = new Deneme("osman");
            Console.WriteLine("-----------------------------------------");
            
            HandleException(() => {
                Find("osman");
            });
            
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        static void Find(string name){
            if (!name.Equals("ahmet")){
                throw new RecordNotFoundExepction("Kayıt bulunamadı kardeş");
            }
            else{
                Console.WriteLine("Kayıt bulundu");
            }
        }
        
    }

    enum Days{
        Pazartesi = 10, Sali, Carsamba, Persembe, Cuma, Cumartesi = 45, Pazar
    }

    class Deneme{

        public string _isim;

        public Deneme(String isim){
            _isim = isim;
        }

        public string soy_isim { get; set; }

    }


}
