namespace MFS.Client.Infrastructure.Routes
{
    public static class CommunityEndpoints
    {
        public static string CreateCommunity = "api/community";
        public static string UpdateCommunity = "api/community";
        public static string DeleteCommunity(int id) => $"api/community/{id}";
    }
}
