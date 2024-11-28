namespace Inside;

internal static class Program
{
    private static void Main(string[] args)
    {
        IExercise exerciseToRun;
        // exerciseToRun = new Exercise315A();
        // exerciseToRun = new Exercise315B();
        // exerciseToRun = new Exercise315C();
        exerciseToRun = new Exercise321A();
        
        exerciseToRun.Run();
    }
}