using SQLite;

namespace OOP.FinalTerm.Exam.Model
{
   
    //Inherit PersonModel
    //PersonModel must be created first if not already present
    public class DirectorModel : PersonModel
    {
        public string Genres { get; set; }
        public int TotalMoviesCreated { get; set; }
        //add properties here
        //refer to README.md for property details
        //refer to MovieModel for guidance
    }
}
