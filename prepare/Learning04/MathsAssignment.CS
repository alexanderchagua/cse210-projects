using System;

public class MathsAssignment : Assignment
{
    private string _texboxSection;
    private string _problems;

    public MathsAssignment(string studentname, string topic, string texboxsection, string problems) : base(studentname, topic)
    {
        _texboxSection = texboxsection;
        _problems = problems;
    }

   public string GetHomeworkList()
    {
        return $"Section {_texboxSection} Problems {_problems}";
    }
}