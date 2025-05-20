# 1. Base image (runtime için)
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# 2. Build image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Projeyi kopyala ve build et
COPY ["EBYS.csproj", "./"]
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o /app/publish

# 3. Final image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish ./
ENTRYPOINT ["dotnet", "EBYS.dll"]
