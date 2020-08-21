# netcore-docker-starter
A starter template project for a Dotnet core api with Docker, x-unit, and 
a preconfigured healthcheck endpoint. 

## Usage
After cloning this repo:

Run Locally: 
```bash
cd local_dir
dotnet run --project=StarterApi
# Now listening on: http://localhost:5000
```

Run image:

```bash
  
  echo "== start StarterApi"
  docker run -d -p 80:80 StarterApi &
  docker ps

  echo "== wait 3s for startup"
  sleep 3s

  echo "== curl health check route"
  curl http://localhost/health 

```

### Additional details

Healthcheck endpoint pre-configured at `/health`

Unit tests setup using x-unit. 

```bash
  dotnet test
```

