#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Stefanini_CRUD.API/Stefanini_CRUD.API.csproj", "src/Stefanini_CRUD.API/"]
COPY ["src/Stefanini_CRUD.Application/Stefanini_CRUD.Application.csproj", "src/Stefanini_CRUD.Application/"]
COPY ["src/Stefanini_CRUD.Infra.Data/Stefanini_CRUD.Infra.Data.csproj", "src/Stefanini_CRUD.Infra.Data/"]
COPY ["src/Stefanini_CRUD.Domain/Stefanini_CRUD.Domain.csproj", "src/Stefanini_CRUD.Domain/"]
RUN dotnet restore "src/Stefanini_CRUD.API/Stefanini_CRUD.API.csproj"
COPY . .
WORKDIR "/src/src/Stefanini_CRUD.API"

RUN dotnet build "Stefanini_CRUD.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Stefanini_CRUD.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Stefanini_CRUD.API.dll"]
