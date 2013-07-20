namespace task
{
    public interface IAction
    {
        bool _isActionId(ActionId nActionId);

        void _runActionId(ActionId nActionId);
    }
}
