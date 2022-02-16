using Microsoft.Data.SqlClient;
using SampleMVCTogetherApp.Exceptions;
using SampleMVCTogetherApp.Models;

namespace SampleMVCTogetherApp.Services
{
    public class UserRepo : IAdding<string, User>
    {
        private readonly ShopContext _context;
        private readonly object e;

        public UserRepo(ShopContext context)
        {
            _context = context;
        }
        public User Add(User item)
        {
            try
            {
                _context.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception)
            {

                    throw new UsernameDuplicateException();
                
            }
            return null; 
        }

        public ICollection<User> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
