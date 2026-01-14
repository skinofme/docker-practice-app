# First stage for build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app
COPY *.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c Release -o source

# Second stage for runtime
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app/source .
ENTRYPOINT ["dotnet", "MyConsoleApp.dll"]

# Important: following environment variable here cannot be a secret env
ENV HOSTED="Docker Container"