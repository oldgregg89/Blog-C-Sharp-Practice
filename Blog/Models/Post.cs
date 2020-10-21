using System.Collections.Generic;

namespace Blog.Models
{
  public class Post
  {
    public string Content { get; set; }
    public string Author { get; set; }
    public string Date { get; set; }
    private static List<Post> _instances = new List<Post> {};

    public Post(string content, string author, string date)
    {
      Content = content;
      Author = author;
      Date = date;
      _instances.Add(this);
    }
    public static List<Post> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}