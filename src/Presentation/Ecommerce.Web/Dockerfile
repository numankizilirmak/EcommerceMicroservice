FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build
WORKDIR /app
RUN curl -sL https://deb.nodesource.com/setup_10.x |  bash -
RUN apt-get install -y nodejs

COPY /*.csproj ./
COPY . .
RUN dotnet publish ./*.csproj -o /publish/
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
RUN curl -sL https://deb.nodesource.com/setup_10.x |  bash -
RUN apt-get install -y nodejs


WORKDIR /app
COPY --from=build /publish .
ENV ASPNETCORE_URLS="http://*:3000"
ENV ASPNETCORE_ENVIRONMENT="Development"
ENTRYPOINT ["dotnet","Ecommerce.Web.dll"]