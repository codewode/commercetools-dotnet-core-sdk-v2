using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("RequiredField")]
    public partial class RequiredFieldError : ErrorObject
    {
        public string Field { get; set;}
        public RequiredFieldError()
        { 
           this.Code = "RequiredField";
        }
    }
}