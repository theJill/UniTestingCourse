using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleNameSpace
{
    public class Triangle
    {
        public static bool IsTriangle(float firstSide, float secondSide, float thirdSide)
        {

            return ((firstSide < secondSide + thirdSide) 
                && (secondSide < firstSide + thirdSide) 
                && (thirdSide < firstSide + secondSide)) 
                && (firstSide > 0 && secondSide > 0 && thirdSide > 0);
        }

        public static bool IsEqualsided(float firstSide, float secondSide, float thirdSide)
        {
            return IsTriangle(firstSide, secondSide, thirdSide) 
                && (firstSide.Equals(secondSide) && secondSide.Equals(thirdSide));
        }

        public static bool IsRightAngled(float firstSide, float secondSide, float thirdSide)
        {
            float[] allSides = { firstSide, secondSide, thirdSide };
            return IsTriangle(firstSide, secondSide, thirdSide) 
                && (Math.Pow(allSides.Distinct().ElementAt(2), 2)
                ==  Math.Pow(allSides.Distinct().ElementAt(1), 2) 
                +   Math.Pow(allSides.Distinct().ElementAt(0), 2));
        }
    }
}
