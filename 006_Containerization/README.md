# Containerizing API Gateways.

This repository contains a POC for containerizing an API gateway and its downstream services. This repository serves as a companion of this blog [post](http://www.pogsdotnet.com/2018/09/containerizing-aspnet-core-api-gateways.html)


### Building the Container Images

To test the endpoints, you can run the *src/0001-Containerize Services.sh* script.

```sh
docker build -t demo/authentication-api ./Authentication/
docker build -t demo/ledger-api ./Ledger/
docker build -t demo/catalog-api ./Catalog/
docker build -t demo/gateway-api ./Gateway/
```

### Running the Container Images

To run the docker images for testing, use *src/0002_Run Docker Images.sh* script.

```sh
docker run -d -p 52792:80 --name demo-auth-api demo/authentication-api
docker run -d -p 52791:80 --name demo-catalog-api demo/catalog-api
docker run -d -p 52790:80 --name demo-ledger-api demo/ledger-api
docker run -d -p 52793:80 --name demo-api-gateway demo/gateway-api
```

### Cleaning the POC Artifacts

To clean the containers and images from your machine, you can run both of the scripts below

#### src/0003_Clean Containers.sh
```sh
docker rm demo-auth-api -f
docker rm demo-catalog-api -f
docker rm demo-ledger-api -f
docker rm demo-api-gateway -f
```

#### src/0004_Clean Images.sh
```sh
docker rmi demo/authentication-api
docker rmi demo/catalog-api
docker rmi demo/ledger-api
docker rmi demo/gateway-api

docker image prune
```

### Support

If you experience some troubles with the containerization process, feel free to hit me up with comments at my [blog post](http://www.pogsdotnet.com/2018/09/containerizing-aspnet-core-api-gateways.html)
