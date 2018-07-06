using System.Collections.Generic;
using API.Models.ViewModels;
using API.Models.EntityModels;
using API.Models.DTOModels;


namespace API.Services.PlayerService
{
    public interface IPlayerService
    {
         IEnumerable<PlayerDTO> getAllPlayers();
         PlayerDTO addPlayer(PlayerViewModel newPlayer);
         PlayerDTO editPlayer(int id, EditPlayerViewModel playerToBeEdited);
         PlayerDTO getPlayerById(int id);
         void deletePlayer(int id);
         IEnumerable<TeammatesDTO> getTeammates(int pid, int pid2);
    }
}