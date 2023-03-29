namespace recursive_extension_metotlar {
    class Program
    {
        static void Main(string[] args)
        {
            //rekürsif - öz yinelemeli
            //3^4
            int result = 1;
            for (int i = 1; i<5; i++)
                result = result * 3;
            Console.WriteLine(result);

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3, 4));
            //extension Metotlar

            string ifade = "yasin ağırbaş";
            bool   sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);

            if (sonuc)
                Console.WriteLine(ifade.RemoveWiteSpaces());
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());
            int[] dizi = {9, 3, 6, 2, 1, 5, 0,};
            dizi.ShortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
           Console.WriteLine(sayi.IsEvenNumber());
           Console.WriteLine(ifade.GetFirstCharacter());
        }
    }

    public class Islemler
        {
            public int Expo(int sayi, int us)
            {
                if (us<2)
                    return sayi;
                return Expo(sayi, us - 1) * sayi;

            }
            //Expo(3,4)
                //Expo(3,3) * 3;
                //Expı (3,2) *3*3;
                //Expo (3,1) *3 *3*3;
                // contains string ifade kütüphanesidir 
                
            }
           

            public static class Extension
            
            {
                public static bool CheckSpaces( this string param)
                {
                    return param.Contains(" ");
                }

                public static string RemoveWiteSpaces( this  string param)

                {
                    string[] dizi = param.Split(" ");
                    return string.Join("*", dizi); //boşluklara * koyar
                }

               public static string MakeUpperCase(this string param)

                {
                    return param.ToUpper();//hepsi büyük olur
                }

                public static string MakeLowerCase( this string param)
                {
                    return param.ToLower(); //hepsi küçük olur
                }

                public static int[] ShortArray(this int[] param)
                {
                    Array.Sort(param);
                    return param;
                }

                public static void EkranaYazdir(this int[] param)
                {
                    foreach (var item  in param)
                    {
                        Console.WriteLine(item);
                    }
                }

                public static bool IsEvenNumber(this int param)
                {
                    return param% 2 == 0;
                }

                public static string GetFirstCharacter(this string param)
                {
                    return param.Substring(0, 1);
                }
            }

        }
    


