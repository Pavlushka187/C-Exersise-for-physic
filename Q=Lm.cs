/***************************************************************
                        Q=-L*m
                        для Вода Воздух Спирт Ртуть Кислород Воздух
***************************************************************/
using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            
            Console.WriteLine("welcome");
            Console.WriteLine("ВВедите жидкость для вычисления конденсации ПРИМЕР (Вода)");
             string жидкость=(Console.ReadLine());
            Console.WriteLine("ВВедите массу жидкости");
            int m = Convert.ToInt32(Console.ReadLine());
                
            if (жидкость == "Вода")
            {
                
                double z = m*3.2;
                    Console.WriteLine($"Q: {z}");
            }
           
            else
            {
                if (жидкость == "Ртуть")
                {
                    double z = m*0.3;
                    Console.WriteLine($"Q: {z}");
                }
                    else
                    {
                        if (жидкость == "Кислород")
                        {
                           double z = m*0.2;
                            Console.WriteLine($"Q: {z}");
                            
                        }
                        else
                        {
                            if (жидкость == "Воздух")
                            {
                                double z = m*0.2;
                                Console.WriteLine($"Q: {z}");
                            }
                            else
                            {
                                if (жидкость == "Спирт")
                                {
                                    double z = m*0.9;
                                    Console.WriteLine($"Q: {z}");
                                }
                                else
                                {
                                    Console.WriteLine("error: не корректное название жидкости");
                                }
                            }
                        }
                    }
                }       
                
              } 
        }
    }


