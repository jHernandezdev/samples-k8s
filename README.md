# Comandos ejecutados

## Crear un SP para acceso al ACR
````az
az ad sp create-for-rbac 
    --scopes /subscriptions/---/resourceGroups/drn-core-rg/providers/Microsoft.ContainerRegistry/registries/--- \
    --role Contributor --name sp-acr-access
````
## Crear los secretos en el cluster
````az
kubectl create secret docker-registry drnacr-key 
    --namespace default \
    --docker-server=[SERVER-ACR]] \
    --docker-username=[API-ID] \
    --docker-password=[PASSWORD]
````
## Crear una cuenta de serivicio y asignarle el role de administrador al namespace default
````bash
kubectl create serviceaccount az-devops

kubectl create rolebinding add-on-default-admin 
    --clusterrole=cluster-admin 
    --serviceaccount=default:az-devops 
    --namespace=default
````