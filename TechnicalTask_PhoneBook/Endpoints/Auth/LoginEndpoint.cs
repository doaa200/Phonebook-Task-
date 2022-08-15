using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Phonebook.Library.Data;
using Phonebook.Library.DTO;

namespace TechnicalTask_PhoneBook.Endpoints.Auth
{
    public class LoginEndpoint : EndpointBaseAsync.WithRequest<LoginViewModel>.WithActionResult<UserManagerResponse>
    {
        private IUserService _userService;
        public LoginEndpoint(IUserService userService)
        {
            _userService = userService;

        }
        [HttpPost("Login")]
        public override async Task<ActionResult<UserManagerResponse>> HandleAsync(LoginViewModel request, CancellationToken cancellationToken = default)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.LoginUserAsync(request);

                if (result.IsSuccess)
                {
                   
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest("Some properties are not valid");
        }
    }
}
