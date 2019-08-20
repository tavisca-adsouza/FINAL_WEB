FROM mcr.microsoft.com/dotnet/core/aspnet

WORKDIR /host

COPY WebApplication2/bin/Debug/netcoreapp2.2/ /host

EXPOSE 80

CMD dotnet WebApplication2.dll