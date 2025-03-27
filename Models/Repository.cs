namespace CourseApp.Models
{
    public static class Repository
    {
        private static List<Candidate> applications = new();
        public static IEnumerable<Candidate> Applications => applications;

        // Form dan gelen elemanları ekleyecek metot
        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }
}