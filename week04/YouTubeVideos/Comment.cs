using System;

public class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    // Constructor to initialize the commenter's name and the comment text
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}
