
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

COPY ./*.sln .
COPY Api/*.csproj Api/
COPY /Models/*.csproj Models/
COPY /Business/*.csproj Business/
COPY /Data/*.csproj Data/
RUN dotnet restore


COPY . .


RUN dotnet publish Api/UrbanTheater.Api.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

ENTRYPOINT ["dotnet", "UrbanTheater.Api.dll"]
