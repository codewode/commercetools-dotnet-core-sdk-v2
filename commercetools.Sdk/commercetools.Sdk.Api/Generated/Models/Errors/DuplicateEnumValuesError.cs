using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class DuplicateEnumValuesError : IDuplicateEnumValuesError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        
        public List<string> Duplicates { get; set;}
        public DuplicateEnumValuesError()
        { 
           this.Code = "DuplicateEnumValues";
        }
    }
}