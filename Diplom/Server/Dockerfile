#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Diplom/Server/Diplom.Server.csproj", "Diplom/Server/"]
COPY ["Diplom.Application.Abstracts/Diplom.Application.Abstracts.csproj", "Diplom.Application.Abstracts/"]
COPY ["Diplom.API.Dto/Diplom.API.Dto.csproj", "Diplom.API.Dto/"]
COPY ["Diplom.Domain/Diplom.Domain.csproj", "Diplom.Domain/"]
COPY ["Diplom.Application/Diplom.Application.csproj", "Diplom.Application/"]
COPY ["Diplom.Domain.Repositories.Abstracts/Diplom.Domain.Repositories.Abstracts.csproj", "Diplom.Domain.Repositories.Abstracts/"]
COPY ["Diplom.Infrastructure.Specifications/Diplom.Domain.Specifications.csproj", "Diplom.Infrastructure.Specifications/"]
COPY ["Diplom.AutoMapper/Diplom.AutoMapper.csproj", "Diplom.AutoMapper/"]
COPY ["Diplom.Mapping/Diplom.Mapping.csproj", "Diplom.Mapping/"]
COPY ["Diplom.Persistence/Diplom.Persistence.csproj", "Diplom.Persistence/"]
COPY ["Domain.Infrastructure.Repositories/Diplom.Infrastructure.Repositories.csproj", "Domain.Infrastructure.Repositories/"]
COPY ["Diplom/Client/Diplom.Client.csproj", "Diplom/Client/"]
COPY ["Diplom.Client.Infrastructure/Diplom.Client.Infrastructure.csproj", "Diplom.Client.Infrastructure/"]
RUN dotnet restore "Diplom/Server/Diplom.Server.csproj"
COPY . .
WORKDIR "/src/Diplom/Server"
RUN dotnet build "Diplom.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Diplom.Server.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Diplom.Server.dll"]