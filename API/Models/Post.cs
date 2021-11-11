namespace API.Models
{
    public class Post
    {
        public int Id {get;set;}

        public string Text {get;set;}

        public int Date {get;set;}

        public override string ToString()
        {
            return Id + " "+ Text + " " + Date;

       } 
    }
}