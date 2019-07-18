﻿using Microsoft.Xrm.Sdk;

namespace Carfup.XTBPlugins.AppCode
{
    public class ControllerManager
    {
        public IOrganizationService SourceService { get; set; }
        public IOrganizationService TargetService { get; set; }
        public DataManager DataManager { get; set; }

        public ControllerManager(IOrganizationService sourceService, IOrganizationService targetService)
        {
            SourceService = sourceService;
            TargetService = targetService;
            DataManager = new DataManager(this);
        }
    }
}
