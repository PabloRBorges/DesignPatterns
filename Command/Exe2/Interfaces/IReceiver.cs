namespace CommandPattern.Exe2.Interfaces
{
    public interface IReceiver<in T, out O>
        where T : ICommand
        where O : IState
    {
        IState Action(T command);
    }
}
