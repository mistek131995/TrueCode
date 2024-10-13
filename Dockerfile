# Этап сборки API
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /api
EXPOSE 8080

# Клонирование репозиториев с клиентом и API
RUN git clone https://github.com/mistek131995/TrueCode.git
RUN git clone https://github.com/mistek131995/true-code-client.git

# Установка Node.js и npm для сборки клиента
RUN apt-get update && apt-get install -y curl \
    && curl -fsSL https://deb.nodesource.com/setup_18.x | bash - \
    && apt-get install -y nodejs

# Перемещаемся в директорию клиента
WORKDIR /api/true-code-client

# Установка всех зависимостей клиента, включая TypeScript и Vite
RUN npm install
RUN npm install -g typescript vite

# Сборка клиента
RUN npm run build

# Перемещаемся обратно в директорию API
WORKDIR "/api/TrueCode/TrueCode.API"
RUN dotnet build "TrueCode.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Этап публикации
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "TrueCode.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Финальный образ
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

# Копируем API из опубликованного образа
COPY --from=publish /app/publish .

# Копируем клиентские файлы (собранные в dist)
COPY --from=build /api/true-code-client/dist ./wwwroot

ENTRYPOINT ["dotnet", "TrueCode.API.dll"]
