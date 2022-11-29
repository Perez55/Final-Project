namespace Final_Project.Models
{
    public class AdminHobby 
    {
        //pk and fk

        public int AdminHobbyId {get;set;}
        public int AdminId {get;set;}
        public int HobbyId{get;set;}

        //Navigation properties
        public Admin admin {get;set;}
        public Hobby hobby {get;set;}


    }






}