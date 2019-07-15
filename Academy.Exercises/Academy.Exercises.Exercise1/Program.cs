using System;
using System.IO;
using Academy.Exercises.Common;
using Academy.Exercises.Entities;


namespace Academy.Exercises.Exercise1
{
    public class Program
    {
        private static Hotel hotel;
        public static void Initialize()
        {
            hotel = new Hotel();
            hotel.Buildings = new Building[]
            {
                new Building()
                {
                    BuildingName = "A",
                    Floors =  new Floor[]
                    {
                        new Floor()
                        {
                            FloorNumber = 1,
                            Rooms = new Space[]
                            {
                                new Hall(Guid.NewGuid()),
                                new BathRoom(Guid.NewGuid()),
                                new MeetingRoom(Guid.NewGuid())
                 
                            }
                        },
                        new Floor()
                        {
                            FloorNumber = 2,
                            Rooms = new Space[]
                            {
                                new Hallway(Guid.NewGuid())
                                {

                                },
                                new Kitchen(Guid.NewGuid())
                                {
                                    
                                },
                                new TechnicalRoom(Guid.NewGuid())
                                {
                                    
                                },
                                new Space(Guid.NewGuid())
                                {
                                    
                                    Spaces = new Space[]
                                    {
                                        new BedRoom(Guid.NewGuid())
                                        {
                                            
                                        }
                                    }
                                },
                                new Space(Guid.NewGuid())
                                {
                                    
                                    Spaces = new Space[]
                                    {
                                        new BedRoom(Guid.NewGuid())
                                        {
                                            
                                        } ,
                                        new BathRoom(Guid.NewGuid())
                                        {

                                        }
                                    }
                                },
                                new Space(Guid.NewGuid())
                                {
                                    Spaces = new Space[]
                                    {
                                        new BedRoom(Guid.NewGuid())
                                        {
                                            
                                        }
                                    }
                                },
                                new Space(Guid.NewGuid())
                                {
                                    Id = Guid.NewGuid(),
                                    Spaces = new Space[]
                                    {
                                        new BedRoom(Guid.NewGuid())
                                        {

                                        },
                                        new BathRoom(Guid.NewGuid())
                                        {
                                        }
                                    }
                                },
                                new Space(Guid.NewGuid())
                                {
                                    Spaces = new Space[]
                                    {
                                        new BedRoom(Guid.NewGuid())
                                        {

                                        },
                                        new BathRoom(Guid.NewGuid())
                                        {

                                        },
                                        new BedRoom(Guid.NewGuid())
                                        {

                                        },
                                        new LivingRoom(Guid.NewGuid())
                                        {

                                        }
                                    }
                                },
                            }
                        }
                    }
                }
            };
            hotel.SetRoomNumbers();
            hotel.Save("./hotel1.json");
        }

        static void Main(string[] args)
        {
            //Initialize();
            //dotnet Academy.Exercises.Exercise1.dll hotel1.json
            if(args.Length == 1)
            {
                try
                {
                    hotel = Utilities.Load(args[0]);
                    //hotel.DisplayTree();
                    WriteMenu();
                }

                catch (Newtonsoft.Json.JsonReaderException)
                {
                    Console.WriteLine("Formato non valido");
                    return;
                }              
                catch(FileNotFoundException)
                {
                    Console.WriteLine("Il file non c'è");
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine("errore: " + e.Message);
                    return;
                }

            }
            else Console.WriteLine("Inserire un parametro");
            Console.ReadLine();
        }

        private static void WriteMenu()
        {
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("1. Mostra albero");
                Console.WriteLine("2. Cerca camera");
                Console.WriteLine("3. Cerca cliente");
                Console.WriteLine("4. Crea cliente");
                Console.WriteLine("ESC per uscire");
                var key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        hotel.DisplayTree();
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        break;

                    case ConsoleKey.D4:
                        Console.Clear();
                        break;

                    case ConsoleKey.Escape:
                        exit = true;
                        break;

            
                    default:
                        Console.Clear();
                        Console.WriteLine("Scelta errata");
                        break;
                }
            }
        }
    }
}
