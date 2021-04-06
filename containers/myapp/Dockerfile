FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS build

# Copiamos el proyecto y restauramos dependencias
WORKDIR /src
COPY *.csproj .
RUN dotnet restore

COPY . . 
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app .

ENTRYPOINT ["dotnet", "myapp.dll"]






