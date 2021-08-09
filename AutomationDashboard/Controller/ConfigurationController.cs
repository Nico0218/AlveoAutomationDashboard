using AutomationDashboard.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace AutomationDashboard.Controller {
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase {
        private readonly ILogger<UserController> logger;
        private ConfigurationService configurationService;

        public ConfigurationController(ILogger<UserController> logger, ConfigurationService configurationService) {
            this.logger = logger;
            this.configurationService = configurationService;
        }

        [HttpGet("IsConfigured")]
        public IActionResult IsConfigured() {
            try {
                return new ObjectResult(configurationService.IsConfigured());
            } catch (Exception ex) {
                //The login failed for an unexpected reason
                logger.LogError($"Server is not configured", ex);
                throw new Exception($"Server is not configured", ex);
            }
        }
    }
}
