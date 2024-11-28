namespace Inside;

class Program
{
    static void Main(string[] args)
    {
        IExercise exerciseToRun;
        exerciseToRun = new Exercise315A();
        exerciseToRun = new Exercise315B();
        exerciseToRun = new Exercise315C();
        
        exerciseToRun.Run();
    }
}