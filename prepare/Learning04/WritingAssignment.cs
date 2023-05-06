using System;

class WriteAssignment : Assignment
{
    private string _title;
    
    public WriteAssignment(string studentName, string topic, string title):base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"{_title}";
    }
}