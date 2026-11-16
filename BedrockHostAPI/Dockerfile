FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["BedrockHostAPI.csproj", "./"]
RUN dotnet restore "BedrockHostAPI.csproj"
COPY . .
RUN dotnet build "BedrockHostAPI.csproj" -c Release -o /app/build

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS publish
WORKDIR /src
COPY . .
RUN dotnet publish "BedrockHostAPI.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BedrockHostAPI.dll"]