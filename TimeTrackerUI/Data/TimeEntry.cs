namespace TimeTrackerUI.Data
{
    public partial class TimeEntry
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public DateTime EntryDate { get; set; } = DateTime.Now;
        public DateTime EntryTime { get; set; } = DateTime.MinValue;
        public DateTime ExitTime { get; set; } = DateTime.MinValue;
        public  DateTime TotalHours { get; set; } = DateTime.MaxValue;

         public override string ToString()
        {
            return $"Today {EntryDate}, Name: {Name} Started work at {EntryTime} and stopped at {ExitTime}. Total Work hours : {(ExitTime - EntryTime).TotalHours}";
        }
    }
}