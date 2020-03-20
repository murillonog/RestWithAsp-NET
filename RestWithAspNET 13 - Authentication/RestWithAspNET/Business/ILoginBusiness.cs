using RestWithAspNET.Model;

namespace RestWithAspNET.Business
{
    public interface ILoginBusiness
    {
        object FindByIdLogin(User user);
    }
}
