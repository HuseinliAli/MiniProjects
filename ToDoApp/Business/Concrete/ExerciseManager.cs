using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ExerciseManager : IExerciseService
    {
        IExerciseDal _exerciseDal;

        public ExerciseManager(IExerciseDal exerciseDal)
        {
            _exerciseDal = exerciseDal;
        }

        public void Add(Exercise exercise)
        {
            _exerciseDal.Add(exercise);
        }

        public void Delete(Exercise exercise)
        {
            _exerciseDal.Delete(exercise);
        }

        public List<Exercise> GetAll()
        {
            return _exerciseDal.GetAll();   
        }

        public void Update(Exercise exercise)
        {
            _exerciseDal.Update(exercise);
        }
    }
}
