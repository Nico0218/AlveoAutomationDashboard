using AutomationDashboard.Common.Security;
using AutomationDashboard.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using Microsoft.Extensions.Logging;

namespace AutomationDashboard.Controller {
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase {
        private ILogger<UserController> logger;
        private UserService userService;

        public UserController(ILogger<UserController> logger, UserService userService) {
            this.logger = logger;
            this.userService = userService;
        }

        [HttpPost("Authentication")]
        public IActionResult Authentication(LoginRequest loginRequest) {
            try {
                User user = userService.authentication(loginRequest);
                if (user == null) {
                    //The login details could not be authenticated
                    return new UnauthorizedResult();
                }
                return new ObjectResult(user);
            } catch (Exception ex) {
                //The login failed for an unexpected reason
                logger.LogError($"Login request failed - {HttpContext.Request.Host}", ex);
                return new UnauthorizedResult();
            }
        }
    }
}
