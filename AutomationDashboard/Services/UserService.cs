using AutomationDashboard.Common.Security;
using System;

namespace AutomationDashboard.Services {
    public class UserService {
        internal User authentication(LoginRequest loginRequest) {
            if (string.IsNullOrEmpty(loginRequest.userName)) {
                throw new ArgumentNullException("UserName");
            }
            if (string.IsNullOrEmpty(loginRequest.password)) {
                throw new ArgumentNullException("Password");
            }
            //Should be a user from a database or something
            if (loginRequest.userName.Equals("admin", StringComparison.OrdinalIgnoreCase) && loginRequest.password.Equals("admin", StringComparison.OrdinalIgnoreCase)) {
                User user = new User();
                user.id = Guid.NewGuid().ToString();
                user.name = loginRequest.userName;
                user.password = "";
                user.role = UserRoles.Admin;
                //Need to use some JWT security tokens 
                user.token = Guid.NewGuid().ToString();
                return user;
            } else {
                throw new Exception("Invalid login request.");
            }
        }
    }
}
