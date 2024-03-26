namespace MFS.Client.Infrastructure.Routes;

public static class NewsItemEndpoints
{
    public static string GetNewsItemById(int id) => $"api/newsitem/{id}";
    public static string CreateNewsItem = "api/newsitem";
    public static string UpdateNewsItem = "api/newsitem";
    public static string DeleteNewsItem(int id) => $"api/newsitem/{id}";
}