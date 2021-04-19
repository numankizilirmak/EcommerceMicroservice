FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
# Install NodeJs
RUN apt-get update && \
apt-get install -y wget && \
apt-get install -y gnupg2 && \
wget -qO- https://deb.nodesource.com/setup_14.x | bash - && \
apt-get install -y build-essential nodejs
# End Install
WORKDIR /app
# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o out
# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .
ENV ASPNETCORE_URLS="http://*:3000"
ENV ASPNETCORE_ENVIRONMENT="Development"
ENTRYPOINT ["dotnet","Ecommerce.Web.dll"]