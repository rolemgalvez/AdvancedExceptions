namespace FirstTry
{
    public static class Section
    {
        public static string Value = "";

        public static void Welcome()
        {
            Console.WriteLine("First Try");
            Console.WriteLine("---------");
            Console.WriteLine();
        }

        public static void Core()
        {
            try
            {
                Process.Main();
            }
            catch (NotImplementedException ex) when (Value == "hi")
            {
                Console.WriteLine("Hello there!");
                Console.WriteLine(ex);
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("Your code is incomplete!");
                Console.WriteLine(ex);
            }
            catch (MethodAccessException ex)
            {
                Console.WriteLine("Who are you?");
                Console.WriteLine(ex);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Something is missing.");
                Console.WriteLine(ex);
            }
            catch (BadImageFormatException ex)
            {
                Console.WriteLine("It is the wrong one.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("We are sure, something is not right.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Just ran the Core");
                Console.WriteLine("-----------------");
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
