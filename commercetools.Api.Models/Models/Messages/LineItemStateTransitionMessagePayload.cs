using commercetools.Api.Models.Messages;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class LineItemStateTransitionMessagePayload : MessagePayload
    {
        public string LineItemId { get; set;}
        
        public DateTime TransitionDate { get; set;}
        
        public long Quantity { get; set;}
        
        public StateReference FromState { get; set;}
        
        public StateReference ToState { get; set;}
    }
}
