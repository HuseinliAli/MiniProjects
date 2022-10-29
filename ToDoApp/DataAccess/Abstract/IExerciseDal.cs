using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IExerciseDal
    {
        List<Exercise> GetAll();
        void Add(Exercise exercise);
        void Delete(Exercise exercise);
        void Update(Exercise exercise);
    }
}
