using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeTrackerUI.Models;
{
    public class TimeTracker
    {
        [Required]
        public int Id { get; set;}
        [Column ("Name")]

        public string PersonName { get; set;} = string.Empty;
        [Column ("EntryForDate")] 

        public DateOnly EntryDate { get; set; } 
        [Column ("EntryTime")] 
        public DateTime EntryTime { get; set; }
        [Column ("ExitTime")] 

        public DateTime ExitTime {get; set; }
        [Column ("TotalHours")] 

        public TimeSpan TotalHours { get; set; }

        public string Columns()
        {
            return $"Id|EntryForDate|Name|EntryTime|ExitTime|TotalHours";
        }

        public override string ToString()
        {
            return $"{Id}|{EntryDate}|{PersonName}|{EntryTime}|{ExitTime}|{(ExitTime - EntryTime).TotalHours}";
        } 
        public TimeTracker(){

        }
        public TimeTracker(string lineRead)
        {
            string[] lineReadArray = lineRead.Split("|");
            Id = Convert.ToInt32(lineReadArray[0]);
            EntryDate = DateOnly.FromDateTime(Convert.ToDateTime(lineReadArray[1]));
            PersonName = lineReadArray[2];
            EntryTime = Convert.ToDateTime(lineReadArray[3]);
            ExitTime = Convert.ToDateTime(lineReadArray[4]);
           // TotalHours = Convert.ToDateTime(lineReadArray[5]);
        }
    }
}






