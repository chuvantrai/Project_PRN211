using Microsoft.AspNetCore.Http;
using Project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Project.Logic
{
    public class ExtensionFile
    {
        public static string AddandUploadImgae(IFormFile myfile, User user)
        {
            if (myfile == null)
            {
                return null;
            }
            //add img
            var newfilename = Guid.NewGuid();
            var _extension = Path.GetExtension(myfile.FileName);
            string _FileName = newfilename + _extension;
            string fullPath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot", "myfiles", _FileName);
            using (var file = new FileStream(fullPath, FileMode.Create))
            {
                myfile.CopyTo(file);
            }

            // delete img 
            if (user.ImgAvar != null)
            {
                string imgPath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot", "myfiles", user.ImgAvar);
                FileInfo fi = new FileInfo(imgPath);
                if (fi != null)
                {
                    System.IO.File.Delete(imgPath);
                    fi.Delete();
                }
            }

            return _FileName;
        }
        public static string AddnewImgae(IFormFile myfile)
        {
            if (myfile == null)
            {
                return null;
            }
            //add img
            var newfilename = Guid.NewGuid();
            var _extension = Path.GetExtension(myfile.FileName);
            string _FileName = newfilename + _extension;
            string fullPath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot", "myfiles", _FileName);
            using (var file = new FileStream(fullPath, FileMode.Create))
            {
                myfile.CopyTo(file);
            }
            return _FileName;
        }
        

    }
}
