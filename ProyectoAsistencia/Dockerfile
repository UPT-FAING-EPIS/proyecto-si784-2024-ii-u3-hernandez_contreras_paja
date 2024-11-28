FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar solo la carpeta ProyectoAsistencia al contenedor
COPY ProyectoAsistencia ./ProyectoAsistencia

# Cambiar al directorio ProyectoAsistencia
WORKDIR /src/ProyectoAsistencia

# Restaurar dependencias del proyecto
RUN dotnet restore

# Compilar el proyecto
RUN dotnet build -c Release -o /app/build

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

# Imagen final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProyectoAsistencia.dll"]
