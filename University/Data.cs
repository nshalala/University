using University.Models;

namespace University
{
    public static class Data
    {
        public static List<Student> Students = new List<Student>()
        {
            new Student(){Id = 1, Group="1031",Name="Ali", Lastname = "Aliyev", Field="Finance"},
            new Student(){Id = 2, Group="1085",Name="Murad", Lastname = "Salimov", Field="Information Technologies"},
            new Student(){Id = 3, Group="1085",Name="Chinara", Lastname = "Alakbarova", Field="Information Technologies"},
            new Student(){Id = 4, Group="1064",Name="Chinara", Lastname = "Alakbarova", Field="Marketing"},
            new Student(){Id = 5, Group="1086",Name="Chinara", Lastname = "Alakbarova", Field="Cybersecurity"},
        };
        public static List<Group> Groups = new List<Group>()
        {
            new Group(){Id = 1, Name= "1031"},
            new Group(){Id = 2, Name= "1064"},
            new Group(){Id = 3, Name= "1085"},
            new Group(){Id = 4, Name= "1086"},
        };
    }
}
