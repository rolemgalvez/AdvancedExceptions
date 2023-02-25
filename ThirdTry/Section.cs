using System.Security.Authentication;
using System.Text.Json;

namespace ThirdTry
{
    public static class Section
    {
        public static string Value = "";

        public static void Welcome()
        {
            Console.WriteLine("Third Try");
            Console.WriteLine("---------");
            Console.WriteLine();
        }

        public static void Core()
        {
            try
            {
                Process.Main();
            }
            catch (NotImplementedException ex) when (Value == "hmm")
            {
                Console.WriteLine("You know what you did.");
                Console.WriteLine(ex);
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("A relative is missing.");
                Console.WriteLine(ex);
            }
            catch (AuthenticationException ex)
            {
                Console.WriteLine("No one knows.");
                Console.WriteLine(ex);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine("We don't have that.");
                Console.WriteLine(ex);
            }
            catch (TaskSchedulerException ex)
            {
                Console.WriteLine("What's next?");
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
