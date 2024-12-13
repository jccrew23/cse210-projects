using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Video {
    
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _vidComments = new List<Comment>();

    public int NumberComments() {
        int numComments = _vidComments.Count();
        return numComments;
    }

    public void DisplayComments() {
        foreach (Comment com in _vidComments) {
            Console.WriteLine($"{com._commenter}: {com._commentText}");
        }
    }
}