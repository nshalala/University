using University.Models;
namespace University.ViewModels;

public class StudentDetailViewModel
{
    public List<Group> Groups { get; set; }
    public Student Std { get; set; }
}