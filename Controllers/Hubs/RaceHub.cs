using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace RaceGame.Controllers.Hubs {
    public class RaceHub : Hub {
        public async Task UserMove(string userId, string key) {
            await Clients.All.SendAsync("UserMove", userId, key);
        }

        public async Task UsuarioEntrou(string userId) {
            await Clients.All.SendAsync("UsuarioEntrou", userId);
        }
    }
}