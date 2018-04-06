FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY Moment.Services.sln ./
COPY NuGet.Config ./
COPY Moment.Services.Api.Business/Moment.Services.Api.Business.csproj Moment.Services.Api.Business/
COPY Moment.Services.Domain/Moment.Services.Domain.csproj Moment.Services.Domain/
COPY Moment.Services.Models/Moment.Services.Models.csproj Moment.Services.Models/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/Moment.Services.Api.Business
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Moment.Services.Api.Business.dll"]
