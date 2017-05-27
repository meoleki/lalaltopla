using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace WebApplication2.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Не введено имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не введен логин")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Не введен пароль")]
        [MinLength(6, ErrorMessage = "Пароль меньше 6 символов")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string CPassword { get; set; }

        [Range(0, 1999, ErrorMessage = "Возраст менее 18 лет")]
        public int Age { get; set; }

        //public  eInputFile { get; set; }

    }
    public class LogInViewModel
    {

        [Required(ErrorMessage = "Не введен логин")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Не введен пароль")]
        [MinLength(6, ErrorMessage = "Пароль меньше 6 символов")]
        public string Password { get; set; }

    }
}