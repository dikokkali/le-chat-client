#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["LeChat.Messaging.API/LeChat.Messaging.API.csproj", "LeChat.Messaging.API/"]
RUN dotnet restore "LeChat.Messaging.API/LeChat.Messaging.API.csproj"
COPY . .
WORKDIR "/src/LeChat.Messaging.API"
RUN dotnet build "LeChat.Messaging.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LeChat.Messaging.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LeChat.Messaging.API.dll"]