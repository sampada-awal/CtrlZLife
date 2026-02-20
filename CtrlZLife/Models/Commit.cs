namespace CtrlZLife.Models
{
    public class Commit
    {
        public int Id { get; set; }
        public int RepoId { get; set; }
        public string Message { get; set; }
        public string Reason { get; set; }
        public string Impact { get; set; }
        public string Tag { get; set; }
        public DateTime Date { get; set; }
    }
}
