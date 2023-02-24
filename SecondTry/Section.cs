namespace SecondTry
{
    public static class Section
    {
        public static void Welcome()
        {
            Console.WriteLine("Second Try");
            Console.WriteLine("----------");
            Console.WriteLine();
        }

        public static void Core()
        {
            try
            {
                Process.Main();
            }
            catch (CannotUnloadAppDomainException ex)
            {
                Console.WriteLine("You cannot do it, are you?");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Check it again!");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong, my friend.");
                Console.WriteLine("ex");
            }
            finally
            {
                Console.WriteLine("--------");
                Console.WriteLine("RAN CORE");
                Console.WriteLine("--------");
            }
        }
    }
}
