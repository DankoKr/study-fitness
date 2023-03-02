using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Fitness
{
    internal interface IMapClient
    {
        void ExerciseAdded(Exercise ex);
        void ExerciseRemoved(Exercise ex);
    }
}
