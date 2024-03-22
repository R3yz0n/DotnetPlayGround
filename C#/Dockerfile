# Use the official .NET Core SDK image as the base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0

# Set the working directory in the container
WORKDIR /app

# Copy the project files into the container
COPY . .

# Restore dependencies and build the application
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Build the runtime image
FROM mcr.microsoft.com/dotnet/runtime:6.0 AS runtime

# Set the working directory in the container
WORKDIR /app

# Copy the published application from the build stage
COPY --from=build /app/out .

# Set the entry point for the container
ENTRYPOINT ["dotnet", "YourAppName.dll"]
