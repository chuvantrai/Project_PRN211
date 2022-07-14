using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.Models;
using System;

namespace Project.Controllers
{
    public class AbstractController : Controller
    {
        public User CheckRoleSession(int[] listrole,bool andor)// true: and, false: or
        {

            // get session
            string jsonStr = HttpContext.Session.GetString("useraccount");
            User user;
            if (jsonStr is null) user = null;
            else user = JsonConvert.DeserializeObject<User>(jsonStr);
            // check session null
            if (user==null)
            {
                Response.Redirect("/nguoidung/dangnhap");
                return null;
            }
            else
            {
                if (andor)
                {
                    // true check role and listrole
                    foreach (int role in listrole)
                    {
                        if (user.RoleId!=role)
                        {
                            Response.Redirect("/nguoidung/eror");
                        }
                        return user;
                    }
                }
                else
                {
                    // check role or listrole
                    foreach (var role in listrole)
                    {
                        if (user.RoleId == role)
                        {
                            return user;
                        }
                    }
                    Response.Redirect("/nguoidung/eror");
                    return null;
                }
            }
            return user;
        }
    }
}
