namespace GuiGradeCalc
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var calc = new GradeCalc();
            Application.Run(calc);
        }
    }
}