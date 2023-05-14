
public class ChecklistlGoal : Goal
{
    public ChecklistlGoal(string typeGoal, string nameGoal, string descriptionGoal, int amountPoint, int bonusValue, int count,int targetCount)
        : base(typeGoal, nameGoal, descriptionGoal, amountPoint)
    {
        _targetCount = targetCount;
        _bonusValue = bonusValue;
        _count = count;
        if (_count == _targetCount)
        {
            _completed = true;
        }
    }

    public override void MarkComplete()
    {
        _count = _count + 1;
        if ( _count == _targetCount)
        {
            _completed = true;
            int totalValue = _amountPoint+_bonusValue;
            Console.WriteLine($"Congratulations! You have earned {totalValue} points.");
            
        }
        else if ( _count < _targetCount)
        {
            Console.WriteLine($"Congratulations! You have earned {GetAmountPoint()} points.");
        }
        else if(_count > _targetCount)
        {
            _bonusValue = 0;
            _amountPoint = 0;
            Console.WriteLine("You have achieved this goal.");
        }
    }
    public override int GetAmountPoint()
    {
        return _amountPoint;
    }

    public override int GetCount()
    {
        return _count;
    }

    public override int GetTargetCount()
    {
        return _targetCount;
    }
    public override string GetEntryAsCSV()
    {

        return string.Format("{0}:{1},{2},{3},{4},{5},{6}", _typeGoal, _nameGoal, _descriptionGoal, _amountPoint, _bonusValue, _count, _targetCount);
    } 

    public override string StatusString()
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

    public override int GetTotalvalue()
    {
        if (_completed)
        {
            return _amountPoint + _bonusValue;
        }
        else
        {
            return _amountPoint;
        }
    }
}
