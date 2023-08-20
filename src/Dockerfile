FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /App

# Copy everything
COPY . ./
# Restore as distinct layers
RUN cd Jyro.API && dotnet restore
# Build and publish a release
RUN cd Jyro.API && dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /App
COPY --from=build-env /App/Jyro.API/out .
EXPOSE 44336
ENTRYPOINT ["dotnet", "Jyro.API.dll"]