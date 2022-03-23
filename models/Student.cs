namespace socialmedia.models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public StudentClass classStudent {get;set;} = StudentClass.TE19D;
    
    }
}