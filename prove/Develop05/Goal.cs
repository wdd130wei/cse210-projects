
public abstract class Goal
{
    protected string _nameGoal;
    protected string _descriptionGoal;
    protected int _amountPoint;
    protected string _typeGoal;
    protected bool _completed;
    protected int _bonusValue;
    protected int _count = 0;
    protected int _targetCount;
    protected int _totalvalue = 0;

    public Goal(string typeGoal, string nameGoal, string descriptionGoal, int amountPoint)
    {
        _typeGoal = typeGoal;
        _nameGoal = nameGoal;
        _descriptionGoal = descriptionGoal;
        _amountPoint = amountPoint;
        _completed = false;
    }
   
    public virtual string GetEntryAsCSV()
    {
        string completedStr = _completed ? "True" : "False";
        return string.Format("{0}:{1},{2},{3},{4}", _typeGoal, _nameGoal, _descriptionGoal, _amountPoint, completedStr);
    } 

    public string GetName()
    {
        return _nameGoal;
    }
    public string GetDescription()
    {
        return _descriptionGoal;
    }
    public virtual string GetGoalType()
    {
        return _typeGoal;
    }
    public virtual int GetAmountPoint()
    {
        return _amountPoint;
    }

    public virtual void MarkComplete()
    {
        _completed = true;
        Console.WriteLine($"Congratulations! You have earned {GetAmountPoint()} points.");
    }

    public virtual string StatusString()
    {
        if (_completed)
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }

    public virtual int GetCount()
    {
        return _count;
    }

    public virtual int GetTargetCount()
    {
        return _targetCount;
    }
    public virtual int GetTotalvalue()
    {
        return _totalvalue;
    }
}