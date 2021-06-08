FROM node:latest as node-build
WORKDIR /app/client
COPY ./client .
RUN npm install
RUN npm run build

FROM mcr.microsoft.com/dotnet/sdk:5.0 as dotnet-build
WORKDIR /app
COPY ./ .
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=dotnet-build ./app/out/publish .
COPY --from=node-build /app/wwwroot/js/client /app/wwwroot/js/client
EXPOSE 5000
ENTRYPOINT ["dotnet", "mvc.dll"]