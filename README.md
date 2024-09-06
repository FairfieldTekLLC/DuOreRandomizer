# DUOreRandomizer

**DUOreRandomizer** is a tool for generating custom ore pool files to randomize ores on planets, excluding Sanctuary.

## Features

- **Custom Ore Pool Generation**: Generate personalized ore pools with custom heatmapping.
- **Directly Usable Files**: The generated files are immediately ready for use in BO.

## Prerequisites

- **For Docker Users:**
  - A functional Docker environment.
  - Basic knowledge of Docker commands and how to edit `docker-compose.yml` files.
  
- **For Linux Users (without Docker):**
  - A Linux-based OS.
  - .NET 6 SDK.
  - Required packages: `libstdc++6`, `libc6`, and `dotnet6`.

## Installation and Setup

### Docker Users

#### 1. Download the Repository

- Clone or download the repository to your local machine.

#### 2. Run Docker Compose

- Navigate to the main folder of the downloaded repository.
- Ensure that the folder contains `generated_files` and `move.sh`.
- Build and start the Docker container by running:

  `docker compose up -d`

#### 3. Access the Container

- Open an interactive shell in the Docker container:

  `docker exec -it ore_randomizer_container /bin/bash`

- You should see a prompt similar to `root@<CONTAINER_ID>:/app#`.

#### 4. Generate the Files

- Inside the container, run:

  `./Ore Randomizer && ./move.sh`

- This will display progress and move the generated files to the `generated_files` directory.

#### 5. Exit the Container

- To exit the interactive shell, type:

  `exit`

#### 6. Cleanup

- To stop and remove the container, run:

  `docker compose down`

- Optionally, clean up unused Docker images and containers to free up space:

  `docker system prune`

### Linux Users (without Docker)

#### 1. Install Required Packages

- Make sure you have the following packages installed:

  `sudo apt-get install libstdc++6 libc6 dotnet6`

#### 2. Build the Application

- Clone or download the repository to your local machine.
- Navigate to the repository's root directory.
- Build the application with:

  `dotnet build`

- This will generate the required files in the `bin/Debug/net6.0` directory of the folder.

#### 3. Generate the Files

- Navigate to the `bin` directory.
- Run the generator with:

  `./Ore Randomizer`

- This will generate the files you need.