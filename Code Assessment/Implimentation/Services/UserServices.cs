using Code_Assessment.Dto;
using Code_Assessment.Interface.IRepositry;
using Code_Assessment.Interface.IServices;

namespace Code_Assessment.Implimentation.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;

        public async Task<BaseResponce<UserDto>> Login(LogingRequesteModel model)
        {
            var userLogin = await _userRepository.LoginAsync(model.Email,model.Password);
            var concFullName = $" {userLogin.User.FirstName} , {userLogin.User.LastName}";
            if (userLogin == null)
                return new BaseResponce<UserDto>
                {
                    Message = "invalid Login Details",
                    Status = false,
                };

            else
            {
                var UserDto = new UserDto
                {
                    Id = userLogin.Id,
                    FirstName = concFullName,
                    LastName = concFullName,
                    Email = userLogin.User.Email,
                    Password = userLogin.User.Password,
                   
                };
                return new BaseResponce<UserDto>
                {
                    Message = "login successful",
                    Status = true,
                    Data = new UserDto
                    {
                        Id = userLogin.Id,
                        FirstName = userLogin.User.FirstName,
                        LastName = userLogin.User.LastName,
                        Email = userLogin.User.Email,
                        Password = userLogin.User.Password,
                       }
                };

            }


        }
    }
}
