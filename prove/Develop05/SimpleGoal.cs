
public class SimpleGoal : Goal
{

    public SimpleGoal(string typeGoal, string nameGoal, string descriptionGoal, int amountPoint, bool isComplete)
        : base(typeGoal, nameGoal, descriptionGoal, amountPoint)
    {
        _completed = isComplete;
    }

}
