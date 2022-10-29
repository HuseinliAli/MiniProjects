using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IExerciseService
    {
        List<Exercise> GetAll();
        void Add(Exercise exercise);
        void Update(Exercise exercise); 
        void Delete(Exercise exercise);
    }
}
