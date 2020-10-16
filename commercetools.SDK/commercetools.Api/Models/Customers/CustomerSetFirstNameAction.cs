using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setFirstName")]
    public partial class CustomerSetFirstNameAction : CustomerUpdateAction
    {
        public string FirstName { get; set;}
        public CustomerSetFirstNameAction()
        { 
           this.Action = "setFirstName";
        }
    }
}