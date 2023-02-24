using System.Net;

namespace HomeworkFourteen
{
    public static class Process
    {
        public static void MainMethod()
        {
            FirstMethod();
            SecondMethod();
            ThirdMethod();
            FourthMethod();
            FifthMethod();
            SixthMethod();
        }

        private static void SixthMethod()
        {
            throw new WebException();
        }

        private static void FifthMethod()
        {
            Section.Value = "henlo";
            throw new NotImplementedException();
        }

        private static string FourthMethod()
        {
            throw new NotImplementedException();
        }

        private static void ThirdMethod()
        {
            throw new ArithmeticException("Your arithmetic is bad.");
        }

        private static void SecondMethod()
        {
            throw new EndOfStreamException("That's for the stream.");
        }

        private static void FirstMethod()
        {
            throw new ArgumentNullException("What a null?");
        }
    }
}
