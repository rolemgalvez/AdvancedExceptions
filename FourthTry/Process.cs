using System.Formats.Asn1;

namespace FourthTry
{
    public static class Process
    {
        public static void Main()
        {
            One();
            Two();
            Three();
            Four();
            Five();
            Six();
        }

        private static void Six()
        {
            throw new AsnContentException("Shhhhhh");
        }

        private static void Five()
        {
            Section.Value = "hoo";
            throw new NotImplementedException("Did you rest?");
        }

        private static void Four()
        {
            throw new NotImplementedException("Aha, that's right.");
        }

        private static void Three()
        {
            throw new InvalidCastException("Open sesame.");
        }

        private static void Two()
        {
            throw new ObjectDisposedException("You owe me.");
        }

        private static void One()
        {
            throw new FileLoadException("Unloaded file it is.");
        }
    }
}
