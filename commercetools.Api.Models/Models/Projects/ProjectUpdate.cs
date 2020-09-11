using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Projects
{
    public class ProjectUpdate 
    {
        public long Version { get; set;}
        
        public List<ProjectUpdateAction> Actions { get; set;}
    }
}
