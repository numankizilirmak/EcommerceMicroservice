FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build
WORKDIR /app

COPY /*.csproj ./
RUN dotnet restore


FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
RUN curl -sL https://deb.nodesource.com/setup_10.x |  bash -
RUN apt-get install -y nodejs

# Setup NodeJs
RUN apt-get update && \
    apt-get install -y wget && \
    apt-get install -y gnupg2 && \
    wget -qO- https://deb.nodesource.com/setup_10.x | bash - && \
    apt-get install -y build-essential nodejs
# Copy everything else and build
COPY . ./
RUN dotnet publish ./*.csproj -o /publish/

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build /publish .
ENV ASPNETCORE_URLS="http://*:3000"
ENV ASPNETCORE_ENVIRONMENT="Development"
ENTRYPOINT ["dotnet","Ecommerce.Web.dll"]