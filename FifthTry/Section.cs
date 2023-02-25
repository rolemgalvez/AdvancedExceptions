namespace FifthTry
{
    public static class Section
    {
        public static string Value = "";
        public static void Welcome()
        {
            Console.WriteLine("Fifth Try");
            Console.WriteLine("---------");
            Console.WriteLine();
        }

        public static void Core()
        {
            try
            {
                Process.Main();
            }
            catch (NotImplementedException ex) when (Value == "dog")
            {
                Console.WriteLine("Relax boy.");
                Console.WriteLine(ex);
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("We knew it!");
                Console.WriteLine(ex);
            }
            catch (TimeoutException ex)
            {
                Console.WriteLine("Wait a minute.");
                Console.WriteLine(ex);
            }
            catch (SystemException ex)
            {
                Console.WriteLine("It has a flaw.");
                Console.WriteLine(ex);
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("Where it is.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("A problem occured.");
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
            Console.WriteLine("");
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}
