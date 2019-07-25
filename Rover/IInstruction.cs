using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public interface IInstruction
    {
       void Follow(Vector vector); 
    }
}
