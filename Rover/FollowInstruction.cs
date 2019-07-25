using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class TurnLeft : IInstruction 
    {
        private static Dictionary<string,string> AfterTurningLeft= new Dictionary<string,string>
        {
            {"N","NW"},
            {"NW","W"},
            {"W","SW"},
            {"SW","S"},
            {"S","SE"},
            {"SE","E"},
            {"E","NE"},
            {"NE","N"}
         };
            public void Follow(Vector vector)
            {
            vector.currentFacingDirection= AfterTurningLeft[vector.currentFacingDirection];
            }
    }

    public class TurnRight : IInstruction
    {
        private static Dictionary<string, string> AfterTurningRight = new Dictionary<string, string>
        {
            {"N","NE"},
            {"NE","E"},
            {"E","SE"},
            {"SE","S"},
            {"S","SW"},
            {"SW","W"},
            {"W","NW"},
            {"NW","N"}
         };
            public void Follow(Vector vector)
        {
            vector.currentFacingDirection = AfterTurningRight[vector.currentFacingDirection];


        }
    }
    public class MoveAhead : IInstruction
    {
        private static Dictionary<string, int> ChangeAlongXAxis = new Dictionary<string, int>
        {
            {"N",0},
            {"NW",-1},
            {"W",-1},
            {"SW",-1},
            {"S",0},
            {"SE",1},
            {"E",1},
            {"NE",1}
         };
        private static Dictionary<string, int> ChangeAlongYAxis = new Dictionary<string, int>
        {
            {"N",1},
            {"NW",1},
            {"W",0},
            {"SW",-1},
            {"S",-1},
            {"SE",-1},
            {"E",0},
            {"NE",1}
         };
        public void Follow(Vector vector)
        {
            int tempXCoordinate=vector.currentXCoordinate + ChangeAlongXAxis[vector.currentFacingDirection];
            int tempYCoordinate=vector.currentYCoordinate + ChangeAlongYAxis[vector.currentFacingDirection];
            if (new Map().IsValidCoordinates(tempXCoordinate + " " + tempYCoordinate) == true)
            {
                vector.currentXCoordinate = tempXCoordinate;
                vector.currentYCoordinate = tempYCoordinate;
            }

        }

    }
}
