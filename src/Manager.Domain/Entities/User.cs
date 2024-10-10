using System;
using System.Collections.Generic;
using Manager.Domain.Validators;

namespace Manager.Domain.Entities
{
    public class User : Base
    {
        //EF
        protected User()
        {
            
        }
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            
            _errors = new List<string>();

            Validate();
        }
        
        // Propriedades
        public string Name { get; private set; }

        public string Email { get; private set; }

        public string Password { get; private set; }

        public void ChangeName(string name)
        {
            Name = name;
            Validate();
        }

        public void ChangeEmail(string email)
        {
            Email = email;
            Validate();
        }

        public void ChangePassword(string password)
        {
            Password = password;
            Validate();
        }
        
        //Autovalida
        public override bool Validate()
        {
            var validator = new UserValidator();
            var validation = validator.Validate(this);

            if (!validation.IsValid)
            {
                foreach (var eror in validation.Errors)
                {
                    _errors.Add(eror.ErrorMessage);
                }

                throw new Exception("Validation Failed" + _errors[0]);
            }

            return true;

        }
        
    }
    
}