# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Set the working directory for the build stage
WORKDIR /app

# Copy the project files and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the remaining files and build the project
COPY . ./
RUN dotnet publish -c Release -o /app/out

# Runtime Stage
FROM ubuntu:22.04 AS runtime

# Install dependencies and utilities
RUN apt-get update && \
    apt-get install -y \
    libstdc++6 \
    libc6 \
    dotnet6 \
    wget && \
    apt-get clean && rm -rf /var/lib/apt/lists/*

# Set the working directory for the runtime stage
WORKDIR /app

# Copy the built application from the build stage
COPY --from=build /app/out .

# Copy any additional shared libraries required by the application
COPY --from=build /app/Dlls/libsharedModule.so .
COPY --from=build /app/move.sh .

# Keep the container running with a shell command
ENTRYPOINT ["/bin/sh", "-c", "while :; do sleep 10; done"]