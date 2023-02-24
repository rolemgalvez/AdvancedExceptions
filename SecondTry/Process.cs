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
