# DUOreRandomizer

**DUOreRandomizer** is a tool for generating custom ore pool files to randomize ores on planets, excluding Sanctuary.

## Features

- **Custom Ore Pool Generation**: Create personalized ore pools with custom heatmapping.
- **Directly Usable Files**: Files generated are immediately ready for use in BO.

## Prerequisites

- A Linux-based OS or a functioning Docker environment.
- Basic knowledge of Docker commands and editing `docker-compose.yml` files.

## Step-by-Step Guide

### 1. Download the Repository

- Clone or download the repository to your local machine.

### 2. Run Docker Compose

- Navigate to the main folder of the downloaded repository.
- Ensure the folder contains `generated_files` and `move.sh`.
- Build and start the Docker container by running:

  `docker compose up -d`

### 3. Access the Container

- Open an interactive shell within the Docker container by executing:

  `docker exec -it ore_randomizer_container /bin/bash`

- You should see a prompt like `root@<CONTAINER_ID>:/app#`.

### 4. Generate the Files

- Inside the container, run:

  `./Ore Randomizer && ./move.sh`

- This will display progress and move the generated files to the `generated_files` directory.

### 5. Exit the Container

- To exit the interactive shell, type:

  `exit`

### 6. Cleanup

- To stop and remove the container, run:

  `docker compose down`

- Optionally, clean up unused Docker images and containers to free up space:

  `docker system prune`