namespace FirstTry
{
    public static class Process
    {
        public static void Main()
        {
            Uno();
            Dos();
            Tres();
            Kwatro();
            Singko();
            Sais();
        }

        private static void Sais()
        {
            throw new FieldAccessException("Guest me.");
        }

        private static void Singko()
        {
            Section.Value = "hi";
            throw new NotImplementedException("It's been a while.");
        }

        private static void Kwatro()
        {
            throw new NotImplementedException("Just waiting...");
        }

        private static void Tres()
        {
            throw new MethodAccessException("Cannot be my friend.");
        }

        private static void Dos()
        {
            throw new DirectoryNotFoundException("Where it is?");
        }

        private static void Uno()
        {
            throw new BadImageFormatException("This speaks thousands of words.");
        }
    }
}
