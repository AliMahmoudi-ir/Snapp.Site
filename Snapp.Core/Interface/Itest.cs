using Snapp.DataAccessLayer.Entites;

namespace Snapp.Core.Interface
{
    public interface Itest
    {
        Task<List<Role>> GetRoles();    
    }
}
