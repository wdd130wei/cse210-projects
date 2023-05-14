
public class EternalGoal : Goal
{

    public EternalGoal(string typeGoal, string nameGoal, string descriptionGoal, int amountPoint)
        : base(typeGoal, nameGoal, descriptionGoal, amountPoint)
    {

    }

    public override string StatusString()
    {
        if (_completed)
        {
            return "[ ]";
        }
        else
        {
            return "[ ]";
        }
    }
    public override string GetEntryAsCSV()
    {
        return string.Format("{0}:{1},{2},{3}", _typeGoal, _nameGoal, _descriptionGoal, _amountPoint);
    } 
}
