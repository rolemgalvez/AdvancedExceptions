namespace FourthTry
{
    public static class Section
    {
        public static string Value = "";

        public static void Welcome()
        {
            Console.WriteLine("Fourth Try");
            Console.WriteLine("----------");
            Console.WriteLine();
        }

        public static void Core()
        {
            try
            {
                Process.Main();
            }
            catch (NotImplementedException ex) when (Value == "hoo")
            {
                Console.WriteLine("Are you tired?");
                Console.WriteLine(ex);
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("Ow men!");
                Console.WriteLine(ex);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Your chant is wrong.");
                Console.WriteLine(ex);
            }
            catch (ObjectDisposedException ex)
            {
                Console.WriteLine("No, you don't.");
                Console.WriteLine(ex);
            }
            catch (FileLoadException ex)
            {
                Console.WriteLine("Weeeesssshhh...");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong.");
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
