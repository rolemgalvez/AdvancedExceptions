using System.Threading.Channels;

namespace FifthTry
{
    public static class Process
    {
        public static void Main()
        {
            Una();
            Pangalawa();
            Pangatlo();
            PangApat();
            PangLima();
            PangAnim();
        }

        private static void PangAnim()
        {
            throw new ChannelClosedException("Turned off.");
        }

        private static void PangLima()
        {
            Section.Value = "dog";
            throw new NotImplementedException("Arggghhh!");
        }

        private static void PangApat()
        {
            throw new NotImplementedException("Oh oh.");
        }

        private static void Pangatlo()
        {
            throw new TimeoutException("Break time.");
        }

        private static void Pangalawa()
        {
            throw new SystemException("Observe your routine.");
        }

        private static void Una()
        {
            throw new AggregateException("The package is missing.");
        }
    }
}
