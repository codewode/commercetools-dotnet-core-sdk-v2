using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setDateOfBirth")]
    public partial class CustomerSetDateOfBirthAction : CustomerUpdateAction
    {
        public DateTime DateOfBirth { get; set;}
        public CustomerSetDateOfBirthAction()
        { 
           this.Action = "setDateOfBirth";
        }
    }
}