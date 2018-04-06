FROM microsoft/dotnet:2.0-runtime AS base
WORKDIR /app

FROM microsoft/aspnetcore-build:latest AS build
WORKDIR /src
COPY Moment.Services.sln ./
COPY NuGet.Config ./
COPY Moment.Services.Daemon/Moment.Services.Daemon.csproj Moment.Services.Daemon/
COPY Moment.Services.Models/Moment.Services.Models.csproj Moment.Services.Models/
RUN dotnet restore -nowarn:msb3202,nu1503

COPY . .
WORKDIR /src/Moment.Services.Daemon
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Moment.Services.Daemon.dll"]
