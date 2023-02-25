namespace SecondTry
{
    public static class Section
    {
        public static string Value = "";

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
            catch (NotImplementedException ex) when (Value == "aha")
            {
                Console.WriteLine("Finish it.");
                Console.WriteLine(ex);
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("Just do it!");
                Console.WriteLine(ex);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("You don't know the place?");
                Console.WriteLine(ex);
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
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("--------");
                Console.WriteLine("RAN CORE");
                Console.WriteLine("--------");
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
