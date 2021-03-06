﻿using HipChatConnect.Controllers.Listeners.TeamCity.Models;
using MediatR;

namespace HipChatConnect.Controllers.Listeners.TeamCity
{
    public class TeamcityBuildNotification : INotification
    {
        public TeamCityModel TeamCityModel { get; }

        public TeamcityBuildNotification(TeamCityModel teamCityModel)
        {
            TeamCityModel = teamCityModel;
        }
    }
}