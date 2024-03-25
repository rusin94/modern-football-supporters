namespace MFS.Client.Infrastructure.Routes;

public static class NewsItemEndpoints
{
    public static string GetAllNewsItems = "api/newsitem";
    public static string GetNewsItemById(int id) => $"api/newsitem/{id}";
    public static string SaveNewsItem = "api/newsitem";
    public static string UpdateNewsItem = "api/newsitem";
    public static string DeleteNewsItem(int id) => $"api/newsitem/{id}";
}