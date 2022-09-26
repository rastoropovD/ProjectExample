namespace LecturesProjectExample.Example.Core.Query;

public interface IQueryHandlerBulk<in TQuery, TResult>
    where TQuery : IQuery
    where TResult : class
{
    Task<IEnumerable<TResult>> Handle(TQuery query);
}