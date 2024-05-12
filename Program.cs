using System;
using System.Runtime.CompilerServices;

namespace _2D_Array_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr =
            {
                {100,-200,300},
                {10,20,-30 },
                {1,-4,9 }
            };



            //Elementleri oldugu kimi print etmek
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int y = 0; y < arr.GetLength(1); y++)
                {
                    Console.Write(arr[i, y] + " ");
                }
                Console.WriteLine();
            }



            //Arrayde butun ededlerin cemini tapmaq

            var sum = 0;


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int y = 0; y < arr.GetLength(1); y++)
                {
                    sum += arr[i, y];
                }
            }
            Console.WriteLine(sum);


            //Arrayde 1 sutunun cemini tapmaq

            var sumFirst = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int y = 0; y < arr.GetLength(1); y++)
                {
                    if (i == 0)
                    {
                        sumFirst += arr[i, y];
                    }
                }
            }

            Console.WriteLine(sumFirst);



            //Arrayde 1 sutunun cemini tapmagin 2 variant

            var sumSecond = 0;

            for (int i = 0; i < 1; i++)
            {
                for (int y = 0; y < arr.GetLength(1); y++)
                {
                    sumSecond += arr[i, y];
                }
            }

            Console.WriteLine(sumSecond);




            //Arrayde neqativ ededleri gosteren ededleri print etmek


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int y = 0; y < arr.GetLength(1); y++)
                {
                    if (arr[i, y] < 0)
                        Console.Write($"{arr[i, y]}, ");
                }
            }


            //Arrayde minimum ve maximum elementi tapmaq

            var max = arr[0, 0];
            var min = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int y = 1; y < arr.GetLength(1); y++)
                {
                    if (max < arr[i, y])
                        max = arr[i, y];
                    if (min > arr[i, y])
                        min = arr[i, y];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"max: {max}");
            Console.WriteLine($"min: {min}");



            //Arrayde musbet cut ededleri 2-e, musbet tek ededleri 1-e, menfi cut ededleri -2-e, menfi tek edederi -1-e cevirmek


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int y = 0; y < arr.GetLength(1); y++)
                {
                    if (arr[i, y] > 0)
                    {
                        if (arr[i, y] == 0)
                            continue;
                        else if (arr[i, y] % 2 == 0)
                            arr[i, y] = 2;
                        else
                            arr[i, y] = 1;
                    }
                    else
                       if (arr[i, y] == 0)
                        continue;
                    else if (arr[i, y] % 2 == 0)
                        arr[i, y] = -2;
                    else
                        arr[i, y] = -1;
                }
            }


            //4x4 arrayin 2-ci sirasini 0 cevirmek


            int[,] newArr = new int[4, 4]
            {
                {100,-200,300,545},
                {10,20,-30,56},
                {1,-4,9,57 },
                {3, 0, 0,0}
            };

            for (int i = 0; i < newArr.GetLength(0); i++)
            {
                if (i == 1)
                {
                    for (int y = 0; y < newArr.GetLength(1); y++)
                    {
                        newArr[i, y] = 0;
                        Console.WriteLine(newArr[i, y]);
                    };
                }
            }


            //3x3 arrayde 3 sutununu 0 cevirin

            int[,] arr3x3 = new int[3, 3]
            {
                  {100,-200,300},
                {10,20,-30},
                {1,-4,9 },
            };


            for (int i = 0; i < arr3x3.GetLength(0); i++)
            {
                if (i == 2)
                {
                    for (int y = 0; y < arr3x3.GetLength(1); y++)
                    {
                        arr3x3[i, y] = 0;
                    }
                }
            }


            //3x3 arrayde sag diaqonaldaki ededlerin cemini tapin


            var summer = 0;

            int[,] newArr3x3 = new int[3, 3]
              {
                  {100,-200,300},
                {10,20,-30},
                {1,-4,9 },
               };




            for (int i = 0; i < newArr3x3.GetLength(0); i++)
            {
                for (int y = 0; y < newArr3x3.GetLength(1); y++)
                {
                    if (y == newArr3x3.GetLength(1) - 1)
                    {
                        summer += newArr3x3[i, y];
                    }
                }
            }

            Console.WriteLine(summer);




            //4x4 arrayde sol diaqonaldaki ededlerin cemini tapin


            int[,] newArr4x4 = new int[4, 4]
            {
                {100,-200,300,545},
                {10,20,-30,56},
                {1,-4,9,57 },
                {3, 0, 0,0}
            };

            var summary = 0;

            for (int i = 0; i < newArr4x4.GetLength(0); i++)
            {
                for (int y = 0; y < newArr.GetLength(1); y++)
                {
                    if (y == 0)
                    {
                        summary += newArr4x4[i, y];
                    }
                }
            }


            //5x5 arrayde sol diaqonaldan asagida qalan hisseni 0-a cevirin


            int[,] arr5x5 = new int[5, 5]
            {
                {100,-200,300,545,547},
                {10,20,-30,56,547},
                {1,-4,9,57,547 },
                {3, 0, 0,0,547},
                {3, 0, 0,0,547}
            };


            for (int i = 0; i < arr5x5.GetLength(0); i++)
            {
                if (i == arr5x5.GetLength(0) - 1)
                {
                    for (int y = 0; y < arr5x5.GetLength(1); y++)
                    {
                        if (y == 0)
                        {
                            arr5x5[i, y] = 0;
                            Console.WriteLine(arr5x5[i, y]);
                        }
                    }
                }
            }


            //5x5 arrayde sol diaqonaldan yuxarida qalan hisseni 0-a cevirin


            for (int i = 0; i < arr5x5.GetLength(0); i++)
            {
                if (i == 0)
                {
                    for (int y = 0; y < arr5x5.GetLength(1); y++)
                    {
                        if (y == 0)
                        {
                            arr5x5[i, y] = 0;
                            Console.WriteLine(arr5x5[i, y]);
                        }
                    }
                }
            }


            //Velimis 2 arrayin uygun elementlerini cemleyib 3 array yaradin



            int[,] arr1 =
            {
                {100,-200,300,1,1,0,5},
                {10, 20, -30, 1, 1, 0,4},
                {1, -4, 9, 1, 1, 0,45},
                {1, -5, 10, 1, 1, 0,565}
            };
            int[,] arr2 =
            {
                {100,-200,300},
                {10,20,-30 },
                {1,-4,9 }
            };
            var row = 0;
            var column = 0;




            for (int i = 0; i < arr1.GetLength(0) && i < arr2.GetLength(0); i++)
            {
                column = 0;
                for (int y = 0; y < arr1.GetLength(1) && y < arr2.GetLength(1); y++)
                {
                    column++;
                }
                row++;
            }

            int[,] arr3 = new int[row, column];





            for (int i = 0; i < arr1.GetLength(0) && i < arr2.GetLength(0); i++)
            {
                for (int y = 0; y < arr1.GetLength(1) && y < arr2.GetLength(1); y++)
                {
                    arr3[i, y] = arr1[i, y] + arr2[i, y];
                }
            }


            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int y = 0; y < arr3.GetLength(1); y++)
                {
                    Console.Write(arr3[i, y] + " ");
                }
                Console.WriteLine();
            }

            //Arrayde her bir row-un ayriliqda cemini tapin

            var sums = 0;

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                sums = 0;
                for (int y = 0; y < arr1.GetLength(1); y++)
                {
                    sums += arr1[i, y];
                }
                Console.WriteLine($"{i}-row-un cemi: {sums}");
            }


            //Arrayde her bir colmn-un cemini tapin

            var summers = 0;

            for (int i = 0; i < arr1.GetLength(1); i++)
            {
                summers = 0;
                for (int y = 0; y < arr1.GetLength(0); y++)
                {
                    summers += arr1[y, i];
                }
                Console.WriteLine(summers);
            }




            //Arrayi shift deyeri qeder saga surusturmek

            var shift = Convert.ToInt32(Console.ReadLine());


            if (shift < arr1.GetLength(1))
            {

                for (int y = 0; y < arr1.GetLength(0); y++)
                {

                    for (int i = 0; i < shift; i++)
                    {
                        Console.Write("0 ");
                    }

                    for (int z = shift; z < arr1.GetLength(1); z++)
                    {
                        Console.Write(arr1[y, z] + " ");
                    }
                    Console.WriteLine();
                }

            }



            //Iki arrayin hasilini tapib 3-cu arraye menimsedin


            var row2 = 0;
            var column2 = 0;




            for (int i = 0; i < arr1.GetLength(0) && i < arr2.GetLength(0); i++)
            {
                column = 0;
                for (int y = 0; y < arr1.GetLength(1) && y < arr2.GetLength(1); y++)
                {
                    column2++;
                }
                row2++;
            }

            int[,] newArr3 = new int[row2, column2];





            for (int i = 0; i < arr1.GetLength(0) && i < arr2.GetLength(0); i++)
            {
                for (int y = 0; y < arr1.GetLength(1) && y < arr2.GetLength(1); y++)
                {
                    newArr3[i, y] = arr1[i, y] * arr2[i, y];
                }
            }


            for (int i = 0; i < newArr3.GetLength(0); i++)
            {
                for (int y = 0; y < newArr3.GetLength(1); y++)
                {
                    Console.Write(newArr3[i, y] + " ");
                }
                Console.WriteLine();
            }



            //Arrayde sade ededleri tapib print etmek 





        }
    }
}
