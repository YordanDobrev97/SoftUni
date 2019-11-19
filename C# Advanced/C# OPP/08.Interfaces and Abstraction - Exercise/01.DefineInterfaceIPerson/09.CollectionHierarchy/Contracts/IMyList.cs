namespace CollectionHierarchy.Contracts
{
    public interface IMyList<T> : IAddCollection<T>, IRemoveCollection<T>, IMyCollection<T>
    {

    }
}
