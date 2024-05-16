using Code_Assessment.Dto;
using static Code_Assessment.Dto.UserDto;

namespace Code_Assessment.Interface.IServices
{
    public interface IUserServices
    {
        Task<BaseResponce<UserDto>> Login(LogingRequesteModel model);
    }
}
