FROM mcr.microsoft.com/dotnet/sdk:5.0 as dotnet-build
WORKDIR /app
COPY ./ .
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=dotnet-build ./app/out .
EXPOSE 5000
ENTRYPOINT ["dotnet", "mvc.dll"]