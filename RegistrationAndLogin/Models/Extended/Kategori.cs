using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RegistrationAndLogin.Models.Extended
{
    public class Kategori
    {

        [Display(Name = "Kategori Adı")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Kategori adı boş olamaz")]
        public string KategoriAdı { get; set; }
    }
}