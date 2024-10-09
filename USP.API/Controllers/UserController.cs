using Microsoft.AspNetCore.Mvc;
using USP.API.Services;

namespace USP.API.Controllers;

public class UserController(IUserService userService, IProductService productService) : ApiBaseController
{
    [HttpPost]
    public async Task<ActionResult> Edit(EditUserCommand command)
    {
        await Mediator.Send(command);
        return Ok();
    }
}

public class EditUserCommand
{
}