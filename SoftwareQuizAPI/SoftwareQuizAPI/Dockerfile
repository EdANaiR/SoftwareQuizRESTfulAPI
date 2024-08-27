# 1. Aþama: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Proje dosyasýný kopyala ve restore et
COPY ["SoftwareQuizAPI/SoftwareQuizAPI/SoftwareQuizAPI.csproj", "SoftwareQuizAPI/"]
RUN dotnet restore "SoftwareQuizAPI/SoftwareQuizAPI/SoftwareQuizAPI.csproj"

# Uygulama kaynak dosyalarýný kopyala ve build et
COPY . ./
WORKDIR "/app/SoftwareQuizAPI/SoftwareQuizAPI"
RUN dotnet publish -c Release -o out

# 2. Aþama: Run
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/SoftwareQuizAPI/SoftwareQuizAPI/out .

# Uygulamayý baþlat
ENTRYPOINT ["dotnet", "SoftwareQuizAPI.dll"]
