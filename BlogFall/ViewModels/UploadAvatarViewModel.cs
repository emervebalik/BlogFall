using BlogFall.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogFall.ViewModels
{
    public class UploadAvatarViewModel
    {
        public string Photo { get; set; }


        [Required(ErrorMessage ="Resim dosyası seçmediniz.")]
        [ProfilePhoto(MaxFileSize = 1000000, ErrorMessage = "Resim boyutu 1 MB olmalıdır.")]
        public HttpPostedFileBase File { get; set; }

    }
}