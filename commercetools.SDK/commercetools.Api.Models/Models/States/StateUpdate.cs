using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.States
{
    public partial class StateUpdate 
    {
        public long Version { get; set;}
        
        public List<StateUpdateAction> Actions { get; set;}
    }
}