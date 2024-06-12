namespace MutationTestingDemo
{
    public class Triangle
    {
        //MERLIN GEORGE
        public static string ValidTriangle(int firstAngle, int secondAngle, int
        thirdAngle)
        {
            string result;
            //Mutant : Consider the triangle as valid only if all the angles are greater than 90 degrees.
            if (firstAngle > 90 && secondAngle > 90 && thirdAngle > 90)

            //Without mutation
            //if ((firstAngle + secondAngle + thirdAngle) == 180)
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            return result;
        }
    }
}
