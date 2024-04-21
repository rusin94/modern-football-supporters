FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
ENV ASPNETCORE_URLS=https://+:5005;http://+:5006
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/MFS.API/MFS.API.csproj", "src/MFS.API/"]
COPY ["src/MFS.Server.Infrastructure/MFS.Server.Infrastructure.csproj", "src/MFS.Infrastructure/"]
COPY ["src/MFS.Server.Persistence/MFS.Server.Persistence.csproj", "src/MFS.Persistence/"]
COPY ["src/MFS.Application/MFS.Application.csproj", "src/MFS.Application/"]
COPY ["src/MFS.Domain/MFS.Domain.csproj", "src/MFS.Domain/"]
COPY ["src/MFS.Client/MFS.Client.csproj", "src/MFS.Client/"]
COPY ["src/MFS.Client.Infrastructure/MFS.Client.Infrastructure.csproj", "src/MFS.Client.Infrastructure/"]

RUN dotnet restore "src/MFS.API/MFS.API.csproj"
COPY . .
WORKDIR "/src/src/MFS.API"

RUN dotnet build "MFS.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "MFS.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
WORKDIR /app/Files
WORKDIR /app
ENTRYPOINT ["dotnet", "MFS.API.dll"]


