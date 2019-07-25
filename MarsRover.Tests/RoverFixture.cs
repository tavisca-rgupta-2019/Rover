using System;
using Xunit;
using FluentAssertions;
namespace MarsRover.Tests
{
    public class RoverFixture
    {
        [Fact]
        public static void Check_Extreme_Cooridates_Tests()
        {
            Rover rover = new Rover();
            rover.Tell("5 5");
            Assert.Equal("5 5", rover.map.GetRangeOfMap());
        }

        [Fact]
        public static void Check_Current_Location_Tests()
        {
            Rover rover = new Rover();
            rover.Tell("5 5");
            rover.Tell("1 2 N");
            Assert.Equal("1 2 N", rover.vector.GetCurrentPosition());
        }

        [Fact]
        public static void Check_Postion_Followed_By_Instruction_Test()
        {
            Rover rover = new Rover();
            rover.Tell("5 5");
            rover.Tell("1 2 NE");
            String ans = rover.Instruction("LMLML");
            Assert.Equal("0 4 W",ans);
        }

        [Fact]
        public static void Check_Multiple_Changes_In_Instruction_Test()
        {
            Rover rover = new Rover();
            rover.Tell("5 5");
            rover.Tell("1 2 NE");
            String ans = rover.Instruction("LMLML");
            Assert.Equal("0 4 W", ans);
            rover.Tell("3 3 E");
             ans = rover.Instruction("MMRM");
            Assert.Equal("5 3 SE", ans);
        }
        [Fact]
        public static void Check_Multiple_Left_Right_Changes_In_Instruction_Test()
        {
            Rover rover = new Rover();
            rover.Tell("5 5");
            rover.Tell("1 0 NE");
            String ans = rover.Instruction("LMLMRMRM");
            Assert.Equal("1 4 NE", ans);
        }
        [Fact]
        public static void Check_Following_Instruction_Ignoring_Out_of_Range_Movement_In_Instruction_Test()
        {
            Rover rover = new Rover();
            rover.Tell("5 5");
            rover.Tell("1 5 N");
            String ans = rover.Instruction("MLMLM");
            Assert.Equal("0 5 W", ans);
        }
        [Fact]
        public static void Check_For_Out_Of_Range_Possition_Followed_By_Instruction_Test()
        {
            Rover rover = new Rover();
            rover.Tell("5 5");
            rover.Tell("1 5 N");
            String ans = rover.Instruction("M");
            Assert.Equal("1 5 N", ans);
           
        }


    }
}
