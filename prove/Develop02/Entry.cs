
class Entry
{
    string date, prompt, response;

    public Entry(string _date, string _prompt, string _response)
    {

    }

    public void DisplayEntry()
    {
        Console.WriteLine
    }

    public string GetEntryAsCSV()
    {
        return string.Format("{0}|{1}|{2}", date, prompt, response);
    } 
}