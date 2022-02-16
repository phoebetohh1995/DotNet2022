using SampleMVCTogetherApp.Models;

namespace SampleMVCTogetherApp.Services
{
    public interface IRepo<K,T> : IAdding<K,T>
    {
        ICollection<T> GetAll();
        
        T Get(K k);
        bool Remove(K id);

        bool Update(T item);
        ICollection<Customer> Get(int id);
    }
}
