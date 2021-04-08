FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS build

WORKDIR /src
COPY webapp.front.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "webapp.front.dll"]