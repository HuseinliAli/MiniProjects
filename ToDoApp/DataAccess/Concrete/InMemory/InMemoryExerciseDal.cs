using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryExerciseDal : IExerciseDal
    {
        List<Exercise> _exercises;

        public InMemoryExerciseDal()
        {
            int zeroZero = 00;
            _exercises = new List<Exercise>
            {
            };
        }

        public void Add(Exercise exercise)
        {
            _exercises.Add(exercise);
        }

        public void Delete(Exercise exercise)
        {
            var exerciseToDelete = _exercises.SingleOrDefault(e=>e.Id == exercise.Id);
            _exercises.Remove(exerciseToDelete);
        }

        public List<Exercise> GetAll()
        {
            return _exercises;
        }

        public void Update(Exercise exercise)
        {
            var exerciseToDelete = _exercises.SingleOrDefault(e => e.Id == exercise.Id);
            exerciseToDelete.Id = exercise.Id;
            exerciseToDelete.Name = exercise.Name;
            exerciseToDelete.Time = exercise.Time;
        }
    }
}
