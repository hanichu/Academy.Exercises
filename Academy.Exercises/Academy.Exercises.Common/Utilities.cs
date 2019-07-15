using Academy.Exercises.Entities;
using System;

using Newtonsoft.Json;
using System.IO;

namespace Academy.Exercises.Common
{
    public static class Utilities
    {

        public static void SetRoomNumbers(this Hotel hotel)
        {
            foreach (Building building in hotel.Buildings)
            {
                foreach (Floor floor in building.Floors)
                {
                    for (int i = 0; i < floor.Rooms.Length; i++)
                    {
                        floor.Rooms[i].Number = $"{building.BuildingName}-{floor.FloorNumber}{i + 1}";
                        //Console.WriteLine(floor.Rooms[i].Number);

                    }
                }
            }
        }

        public static void DisplayTree(this Hotel hotel)
        {
            foreach (Building building in hotel.Buildings)
            {
                Console.WriteLine(building.BuildingName);
                foreach (Floor floor in building.Floors)
                {
                    Console.WriteLine(" F-" + floor.FloorNumber);
                    for (int i = 0; i < floor.Rooms.Length; i++)
                    {
                        Console.WriteLine("  "+floor.Rooms[i].Number + "\t" + floor.Rooms[i].Id);

                    }
                }
            }
        } 

        public static void Save(this Hotel hotel, string path)
        {
            string json = JsonConvert.SerializeObject(hotel);
            File.WriteAllText(path, json);
        }
        public static Hotel Load(string path)
        {
            var json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<Hotel>(json);
        }
    }
}
