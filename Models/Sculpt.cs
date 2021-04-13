using System.ComponentModel.DataAnnotations;

namespace Archive.Models
{
    public class Sculpt
    {
        public int Id { get; set;}

        [Required]
        public string Name { get; set;}

        public int MakerId {get; set;}

        //Todo add tags, need to research some way to store the tags efficiently




    }
}