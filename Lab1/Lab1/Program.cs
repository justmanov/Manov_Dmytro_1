using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json;


namespace Lab1 
    { 
       
        class Program
        {
            static void Main( string[] args)
            {  
                Time time = new Time();
                time.SetTime();
                time.ShowTime();
                time.ChangeHour();
                time.ChangeMinute();
                time.ChangeSecond();
                time.ShowTime();
                Time timejson = new Time()
                {
                    hour = "7",
                    minute ="20",
                    second = "00"
                };
                timejson.ShowTime();
            string json = JsonConvert.SerializeObject(timejson, Formatting.Indented);

            File.WriteAllText(@"C:\Users\Game\source\repos\Lab1\time.json", json);
            Console.WriteLine("...Creating json file with this data:");
            Console.WriteLine(json);
            string jsonString = File.ReadAllText(@"C:\Users\Game\source\repos\Lab1\newObject.json");
            Time time2 = JsonConvert.DeserializeObject<Time>(jsonString);
            Console.WriteLine("-------------------------");
            time2.ShowTime();


        }

    }

    }
