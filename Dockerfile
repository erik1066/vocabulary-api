# Build stage
FROM mcr.microsoft.com/dotnet/core/sdk:3.0-alpine as build

ENV DOTNET_CLI_TELEMETRY_OPTOUT true

COPY src /src
WORKDIR /src

RUN dotnet publish -c Release

# Run stage
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-alpine as run

RUN apk update && apk upgrade --no-cache

ARG VOCABULARY_PORT

ENV VOCABULARY_PORT ${VOCABULARY_PORT}

EXPOSE ${VOCABULARY_PORT}/tcp
ENV ASPNETCORE_URLS http://*:${VOCABULARY_PORT}

COPY --from=build /src/bin/Release/netcoreapp3.0/publish /app
WORKDIR /app

# don't run as root user
RUN chown 1001:0 /app/Cdc.Vocabulary.WebApi.dll
RUN chmod g+rwx /app/Cdc.Vocabulary.WebApi.dll
USER 1001

ENTRYPOINT [ "dotnet", "Cdc.Vocabulary.WebApi.dll" ]

