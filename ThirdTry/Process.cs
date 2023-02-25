using System.Net;
using System.Security.Authentication;
using System.Text.Json;

namespace ThirdTry
{
    public static class Process
    {
        public static void Main()
        {
            Sayo();
            Duwa();
            Tulo();
            Upat();
            Lima();
            Unom();
        }

        private static void Unom()
        {
            throw new CookieException();
        }

        private static void Lima()
        {
            Section.Value = "hmm";
            throw new NotImplementedException("What, again?");
        }

        private static void Upat()
        {
            throw new NotImplementedException("Where is my son?");
        }

        private static void Tulo()
        {
            throw new AuthenticationException("Who are you?");
        }

        private static void Duwa()
        {
            throw new NotSupportedException("This is unknown.");
        }

        private static void Sayo()
        {
            throw new TaskSchedulerException("To do list.");
        }
    }
}
