using System;
using System.Collections.Generic;

namespace MarsRover
{
    public class Rover
    {
        public Map map = new Map();
        public Vector vector = new Vector();
        private IInstruction _ins = null; 
        private static Dictionary<char, IInstruction> SupportedInstrcutions = new Dictionary<char, IInstruction>
        {
            {'L', new TurnLeft()},
            {'R', new TurnRight()},
            {'M', new MoveAhead()},
           
        };
         
        public void Tell(String statement)
        {
            if(statement.Length==3)
                map.SetRangeOfMap(statement);
            else
                if (map.IsValidCoordinates(statement))
                    vector.SetCurrentPosition(statement);
        }
        public string Instruction(String statement)
        {
            foreach(var instruct in statement)
            {
                _ins = SupportedInstrcutions[instruct];
                _ins.Follow(vector);
            }
            return vector.GetCurrentPosition();
            
        }
    }
}
