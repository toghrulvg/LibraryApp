using Domain.Models;
using Service;
using Service.Helpers;
using System;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryService libraryService = new LibraryService();

            Helper.WriteConsole(ConsoleColor.Blue, "Selecet one option : ");
            Helper.WriteConsole(ConsoleColor.Magenta, "1 - Create Library, 2 - Get library by id , 3 - Update library, 4 - Delete library");

            while (true)
            {
                SelectOption: string selecetOption = Console.ReadLine();

                int seletcTrueOption;

                bool isSelecetOption = int.TryParse(selecetOption, out seletcTrueOption);

                if (isSelecetOption)
                {
                    switch (seletcTrueOption)
                    {
                        case 1:
                            Helper.WriteConsole(ConsoleColor.Blue, "add library name : ");
                            string libraryName = Console.ReadLine();
                            Helper.WriteConsole(ConsoleColor.Blue, "add library seatcount : ");
                            SeatCount:  string librarySeatCount = Console.ReadLine();

                            int seatCount;

                            bool isSeatCount = int.TryParse(librarySeatCount, out seatCount);
                            if (isSeatCount)
                            {
                                Library library = new Library
                                {
                                    Name = libraryName,
                                    SeatCount = seatCount
                                };

                                var result = libraryService.Create(library);
                                Helper.WriteConsole(ConsoleColor.Green, $"Library id : {result.Id}, Library name : {result.Name} , seatcount : {result.SeatCount}");
                            }
                            else
                            {
                                Helper.WriteConsole(ConsoleColor.Red, "add correct seatcount : ");
                                goto SeatCount;
                            }


                            break;
                        case 2:
                            Console.WriteLine(seletcTrueOption);
                            break;
                        case 3:
                            Console.WriteLine(seletcTrueOption);
                            break;
                        case 4:
                            Console.WriteLine(seletcTrueOption);
                            break;
                        default:
                            Console.WriteLine("Select corr number");
                            break;

                    }
                }
                else
                {
                    Helper.WriteConsole(ConsoleColor.Red, "Selecet duz option day saat 2di");
                    goto SelectOption;
                }

            }
        }
    }
}
