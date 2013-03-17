namespace DemoApplication.Controllers.Account
{
    #region

    using System.Web.Mvc;
    using System.Web.Security;
    using Core.Common.Membership;
    using Core.Common.Profiles;
    using Models.Account;

    #endregion

    public partial class AccountController
    {
        public ActionResult ChangePassword(string username)
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                var status = _userService.ChangePassword(UserProfile.Current, model.OldPassword, model.NewPassword);

                switch (status)
                {
                    case ChangePasswordStatus.Success:
                        
                        TempData["Success"] = "Password was changed successfully";

                        return Redirect(FormsAuthentication.DefaultUrl);
                        
                    case ChangePasswordStatus.InvalidPassword:
                        ModelState.AddModelError(string.Empty, "The current password is incorrect or the new password is invalid.");
                        break;
                    case ChangePasswordStatus.Failure:
                        ModelState.AddModelError(string.Empty, "An unexpected error occurred.");
                        break;
                }
            }

            ViewBag.PasswordLength = 6; // todo: this should come from a "membership" setting configuration element
            return View(model);
        }
    }
}
