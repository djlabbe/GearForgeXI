# --- build the React client ---
FROM node:20-alpine AS client-build
WORKDIR /client
COPY Client/package*.json ./
RUN npm ci
COPY Client/ ./
RUN npm run build   # outputs to /client/dist

# --- build/publish the .NET API ---
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
# bring the client build into the API's wwwroot
COPY --from=client-build /client/dist/ /src/Api/wwwroot/
RUN dotnet restore ./Api/GearForgeXI.csproj
# Skip the csproj’s npm target inside the container
RUN dotnet publish ./Api/GearForgeXI.csproj -c Release -o /out /p:SkipClientBuild=true

# --- runtime image ---
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
ENV ASPNETCORE_URLS=http://0.0.0.0:8080
EXPOSE 8080
COPY --from=build /out ./
ENTRYPOINT ["dotnet", "GearForgeXI.dll"]
