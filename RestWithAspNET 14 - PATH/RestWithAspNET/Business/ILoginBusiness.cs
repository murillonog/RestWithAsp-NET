using RestWithAspNET.Data.VO;

namespace RestWithAspNET.Business
{
    public interface ILoginBusiness
    {
        object FindByIdLogin(UserVO user);
    }
}
