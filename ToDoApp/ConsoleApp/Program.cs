using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exerciseManager = new ExerciseManager(new InMemoryExerciseDal());
            AddExerise(exerciseManager);
            GetAllExercises(exerciseManager);
        }
        private static void UpdateExerise(ExerciseManager exerciseManager)
        {
            Console.WriteLine("********* WELCOME TO EXERCISE UPDATE *********");
            GetAllExercises(exerciseManager);
            Console.Write("Id : ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("\nExercise Name : ");
            string name = Console.ReadLine();
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            Console.Write("\nDay : ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("\nHour : ");
            int hour = int.Parse(Console.ReadLine());
            Console.Write("\nMinute: ");
            int minute = int.Parse(Console.ReadLine());
            int second = 00;
            var exercise = new Exercise { Id=id, Name=name, Time = new DateTime(year, month, day, hour, minute, second) };
            exerciseManager.Update(exercise);
        }
        private static void AddExerise(ExerciseManager exerciseManager)
        {
            Console.WriteLine("\n********* WELCOME TO EXERCISE ADD *********");
            GetAllExercises(exerciseManager);
            Console.Write("Id : ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("\nExercise Name : ");
            string name = Console.ReadLine();
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            Console.Write("\nDay : ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("\nHour : ");
            int hour = int.Parse(Console.ReadLine());
            Console.Write("\nMinute: ");
            int minute = int.Parse(Console.ReadLine());
            int second = 00;
            var exercise = new Exercise { Id=id, Name=name, Time = new DateTime(year, month, day, hour, minute, second) };
            exerciseManager.Add(exercise);
        }

        private static void GetAllExercises(ExerciseManager exerciseManager)
        {
            Console.WriteLine("********* WELCOME TO EXERCISE LIST *********");
            foreach (var item in exerciseManager.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Time);
            }
        }
    }
}
