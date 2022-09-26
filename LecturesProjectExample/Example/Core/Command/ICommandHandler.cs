namespace LecturesProjectExample.Example.Core.Command;

public interface ICommandHandler
{
    Task Handle();
}

public interface ICommandHandler<in TCommand> where TCommand : ICommand
{
    Task Handle(TCommand command);
}