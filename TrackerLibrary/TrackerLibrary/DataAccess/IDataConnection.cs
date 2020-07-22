﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
        PersonModel CreatePerson(PersonModel model);
        List<PersonModel> GetPersonAll();
        TournamentModel CreateTournament(TournamentModel model);
        List<TeamModel> GetTeamAll();
        TeamModel CreateTeam(TeamModel model);
    }
}
