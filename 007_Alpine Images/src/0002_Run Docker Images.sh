docker run -d -p 52792:80 --name demo-auth-api demo/authentication-api
docker run -d -p 52791:80 --name demo-catalog-api demo/catalog-api
docker run -d -p 52790:80 --name demo-ledger-api demo/ledger-api
docker run -d -p 52793:80 --name demo-api-gateway demo/gateway-api