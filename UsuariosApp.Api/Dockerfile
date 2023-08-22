#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["UsuariosApp.Api/UsuariosApp.Api.csproj", "UsuariosApp.Api/"]
COPY ["UsuariosApp.Application/UsuariosApp.Application.csproj", "UsuariosApp.Application/"]
COPY ["UsuariosApp.Domain/UsuariosApp.Domain.csproj", "UsuariosApp.Domain/"]
COPY ["UsuariosApp.Infra.Data/UsuariosApp.Infra.Data.csproj", "UsuariosApp.Infra.Data/"]
COPY ["UsuariosApp.Infra.Identity/UsuariosApp.Infra.Identity.csproj", "UsuariosApp.Infra.Identity/"]
COPY ["UsuariosApp.Infra.Messages/UsuariosApp.Infra.Messages.csproj", "UsuariosApp.Infra.Messages/"]


RUN dotnet restore "UsuariosApp.Api/UsuariosApp.Api.csproj"
COPY . .
WORKDIR "/src/UsuariosApp.Api"
RUN dotnet build "UsuariosApp.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UsuariosApp.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UsuariosApp.Api.dll"]