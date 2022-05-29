using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("");
            Console.WriteLine("Yasinizi daxil edin:  ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)

            {
                Console.WriteLine("Ingilis dilinden imtahan baliniz: ");
                int point = Convert.ToInt32(Console.ReadLine());
                if (point > 50)

                {
                    Console.WriteLine("Tebrikler. Siz kursa qebul olundunuz. ");
                    goto Start;
                }
                else
                {
                    Console.WriteLine("Sizin baliniz yeterli deyil(Baliniz 50den yuari olmalidir)");
                    Console.WriteLine("Proqram sona catdi.");

                }
            }
            else
            {
                Console.WriteLine("Diqqet!!! Sizin yasiniz 18-den asagi oldugu ucun, kursa qebul olunmadiniz.");
            }

                    Console.WriteLine("Yeniden daxil olmaq iseyirsiniz?:  (He/Yox)");
                    string result = Console.ReadLine();

                    
                    if (result == "Yox")
                    {
                         Console.WriteLine("Proqram sona catdi");
                         
                        }
                        else
                        {
                        
                            goto Start;
                        }
                    
                    

                    }
                }
            }

            

    

            
        
    

