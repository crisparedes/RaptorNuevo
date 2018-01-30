using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace RaptorENEL_V._1._0.Models
{
    [Table("auth_user", Schema = "public")]
    public class Login
    {
        //[Required(ErrorMessage = " Debe ingresar un usuario")]
        //[StringLength(150, ErrorMessage = " El usuario no pueden tener mas de 15 caracteres")]
        public String username { get; set; }

        //[Required(ErrorMessage = " Debe ingresar una contraseña válida")]
        //[StringLength(15, ErrorMessage = " La contraseña debe tener entre 8 y 15 carácteres", MinimumLength = 8)]
        //[DataType(DataType.Password)]
        //[RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^\da-zA-Z])(.{8,15})$", ErrorMessage = " * No válida")]
        public String password { get; set; }

        //[Required(ErrorMessage = " Debe ingresar un correo valido")]
        public String email { get; set; }

    }
}