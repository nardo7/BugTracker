using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BugTracker.BugDataModel
{
    public class Bug
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Display(Name ="Erroneous behavior")]
        public string ErroneousBehavior { get; set; }

        [Display(Name = "How to reproduce")]
        public string HowToReproduce { get; set; }

        [Display(Name = "Worked Time", AutoGenerateField = false)]
        [Required]
        public DateTime WorkedTime { get; set; }


        [Required]
        public int priorityId { get; set; }

        public State state { get; set; }

        public Priority Priority { get; set; }



    }

    public class State
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }

    public class Priority
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Level of priority")]
        public int LevelOfPriority { get; set; }

        public ICollection<Bug> Bugs { get; set; }
    }

    
}
