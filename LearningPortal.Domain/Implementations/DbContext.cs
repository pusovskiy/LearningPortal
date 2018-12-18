using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Common;
using LearningPortal.Domain.Interfaces;

namespace LearningPortal.Domain.Implementations
{
    public class DbContext 
    {
        protected SqlConnection connection;

        protected readonly string connectString= ConfigurationManager.
            ConnectionStrings["DbLearningPortal"].ConnectionString;

        
    }
}
