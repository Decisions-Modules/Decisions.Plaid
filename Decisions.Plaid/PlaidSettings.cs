using System;
using DecisionsFramework.Data.ORMapper;
using DecisionsFramework.Design.Properties;
using DecisionsFramework.ServiceLayer;
using DecisionsFramework.ServiceLayer.Actions;
using DecisionsFramework.ServiceLayer.Actions.Common;
using DecisionsFramework.ServiceLayer.Services.Accounts;
using DecisionsFramework.ServiceLayer.Services.Administration;
using DecisionsFramework.ServiceLayer.Services.Folder;
using DecisionsFramework.ServiceLayer.Utilities;

namespace Decisions.Plaid
{
    public class PlaidSettings : AbstractModuleSettings, IInitializable
    {
        [ORMField]
        [PropertyClassification(0, "Base URL", "Plaid")]
        public string PlaidBaseUrl { get; set; }
        

        public void Initialize()
        {
            // Read the Settings here
            ModuleSettingsAccessor<PlaidSettings>.GetSettings();
        }
        
    }
}