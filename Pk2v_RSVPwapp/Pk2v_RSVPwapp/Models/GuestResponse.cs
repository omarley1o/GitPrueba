using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//para validar
using System.ComponentModel.DataAnnotations;


namespace Pk2v_RSVPwapp.Models
{
    public class GuestResponse
    {
        
    [Required(ErrorMessage="por favor ingrese su nombre.")]
        public string Name { get; set; }
       [Required(ErrorMessage = "por favor ingrese su correo electronico.")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage="por favor ingrese una cuenta de correo valida")]
        public string Email { get; set; }
        [Required(ErrorMessage = "por favor ingrese su numero telefonico.")]
       
        public string Phone { get; set; }
        [Required(ErrorMessage = "por favor especifique si asistira o no.")]
        public bool? WillAttend { get; set; }
    }
}