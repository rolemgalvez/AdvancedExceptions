namespace SecondTry
{
    public static class Process
    {
        public static void Main()
        {
            Isa();
            Dalawa();
            Tatlo();
            Apat();
            Lima();
            Anim();
        }

        private static void Anim()
        {
            throw new HttpRequestException("Connect please.");
        }

        private static void Lima()
        {
            Section.Value = "aha";
            throw new NotImplementedException("It is not done yet.");
        }

        private static void Apat()
        {
            throw new NotImplementedException("You missed it.");
        }

        private static void Tatlo()
        {
            throw new DirectoryNotFoundException("The location is missing.");
        }

        private static void Dalawa()
        {
            throw new CannotUnloadAppDomainException("Your domain is messed up.");
        }

        private static void Isa()
        {
            throw new FormatException("You didn't follow the template.");
        }
    }
}
