using Microsoft.AspNetCore.Components.Authorization;

namespace Trackr
{
    public class AppState : IAppState
    {
        private readonly AuthenticationStateProvider authenticationStateProvider;

        public AppState(AuthenticationStateProvider authenticationStateProvider)
        {
            this.authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<string> GetCurrentUser()
        {
            var authstate = await this.authenticationStateProvider.GetAuthenticationStateAsync();
            var currentUser = authstate?.User?.Identity?.Name;
            if (currentUser != null && !currentUser.Equals("", StringComparison.Ordinal))
            {
                return currentUser;
            }
            return string.Empty;
        }
    }
}
