using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Phonebook.Library.Data;
using Phonebook.Library.DTO;

namespace TechnicalTask_PhoneBook.Endpoints.Auth
{
    public class RegisterEndpoint : EndpointBaseAsync.WithRequest<RegisterViewModel>.WithActionResult<UserManagerResponse>
    {
        private IUserService _userService;
        public RegisterEndpoint(IUserService userService)
        {
            _userService = userService;
           
        }
        [HttpPost("Register")]
        public override async Task<ActionResult<UserManagerResponse>> HandleAsync(RegisterViewModel request, CancellationToken cancellationToken = default)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.RegisterUserAsync(request);

                if (result.IsSuccess)
                    return Ok(result);

                return BadRequest(result);
            }

            return BadRequest("Some properties are not valid");
        }
    }
}
