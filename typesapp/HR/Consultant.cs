namespace com.Transflower.Types.HR
{
   public class Consultant : Person, IWorker, IPresenter
    {
        public int ExperienceYears { get; set; }
        public Consultant(string n, int a, int exp) : base(n, a)
        {
            ExperienceYears = exp;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is working as a consultant.");
        }

        public void Present()
        {
            Console.WriteLine($"{Name} is presenting a report.");
        }
    }
}