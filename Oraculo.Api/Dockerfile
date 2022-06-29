#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Oraculo.Api/Oraculo.Api.csproj", "Oraculo.Api/"]
RUN dotnet restore "Oraculo.Api/Oraculo.Api.csproj"
COPY . .
WORKDIR "/src/Oraculo.Api"
RUN dotnet build "Oraculo.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Oraculo.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Oraculo.Api.dll"]