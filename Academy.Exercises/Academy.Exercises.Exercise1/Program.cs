using System;
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


        }

        static void Main(string[] args)
        {
            Initialize();

            hotel.SetRoomNumbers();
            hotel.DisplayTree();

            Console.ReadLine();
        }
    }
}
