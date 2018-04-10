FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 5000

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY Sherweb.HackDon.sln ./
COPY Sherweb.HackDon.Api/Sherweb.HackDon.Api.csproj Sherweb.HackDon.Api/
COPY Sherweb.HackDon.Models/Sherweb.HackDon.Models.csproj Sherweb.HackDon.Models/
COPY Sherweb.HackDon.Domain/Sherweb.HackDon.Domain.csproj Sherweb.HackDon.Domain/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/Sherweb.HackDon.Api
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Sherweb.HackDon.Api.dll"]
