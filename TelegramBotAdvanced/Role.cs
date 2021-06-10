using System.ComponentModel.DataAnnotations;

namespace TelegramBotAdvanced
{
    public class Role : ValidationAttribute
    {
        private readonly int _userRole;
        private readonly int _userRoleRequired;
        
        public Role(int userRole, int userRoleRequired) {
            _userRole = userRole;
            _userRoleRequired = userRoleRequired;
        }
        
        public override bool IsValid(object value)
        {
            return value != null && _userRole == _userRoleRequired;
        }
    }
}
