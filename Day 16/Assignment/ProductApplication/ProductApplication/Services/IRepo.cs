namespace ProductApplication.Services
{
    public interface IRepo<K,T>
    {
        bool Create(T t);
        bool Edit(K k, T t);
        bool Delete(K k);
        ICollection<T> GetAll();
        T GetT(K k);


    }
}
