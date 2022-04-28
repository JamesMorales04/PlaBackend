#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE $PORT
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PLA.WebApi/PLA.WebAPI.csproj", "PLA.WebApi/"]
COPY ["PLA.Domain/PLA.Domain.csproj", "PLA.Domain/"]
COPY ["PLA.Infrastructure/PLA.Infrastructure.csproj", "PLA.Infrastructure/"]
RUN dotnet restore "PLA.WebApi/PLA.WebAPI.csproj"
COPY . .
WORKDIR "/src/PLA.WebApi"
RUN dotnet build "PLA.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PLA.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app

COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet PLA.WebAPI.dll