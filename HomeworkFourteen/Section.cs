namespace HomeworkFourteen
{
    public static class Section
    {
        public static string Value = "";

        public static void Welcome()
        {
            Console.WriteLine("Homework Fourteen");
            Console.WriteLine("-----------------");
            Console.WriteLine();
        }

        public static void Core()
        {
            try
            {
                Process.MainMethod();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Your argument is null my friend!");
                Console.WriteLine(ex);
            }
            catch (EndOfStreamException ex)
            {
                Console.WriteLine("I think you're having too much netflix!");
                Console.WriteLine(ex);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("You need to review your math!");
                Console.WriteLine(ex);
            }
            catch (NotImplementedException ex) when (Value == "henlo")
            {
                Console.WriteLine("You said something interesting!");
                Console.WriteLine(ex);
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("Your code is not done!");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("You've done a funny mistake!");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("You've just run the Core.");
                Console.WriteLine("--------------------------");
            }
        }

        public static void End()
        {
            Console.WriteLine();
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}
