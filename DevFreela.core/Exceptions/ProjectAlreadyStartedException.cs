using System;

namespace DevFreela.core.Exceptions;

public class ProjectAlreadyStartedException : Exception
{
     public ProjectAlreadyStartedException() : base("Project is already in starded status")
        {

        }

}
