using System;
using System.ComponentModel.DataAnnotations;

namespace OperasWebApp.Models
{
    public class CheckValidYear : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int år = (int)value;
            if (år < 1598)
            {
                ErrorMessage = "We can't accept Opera earlier than 1598";
                return false; 
            }
            else
            {
                return true;
            }
        }
    }
}