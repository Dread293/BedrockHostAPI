# BedrockHostProyecto - Backend Web API (.NET 10 & PostgreSQL)

Proyecto académico desarrollado para el equipo **Bedrocks**.

## Integrantes y Tabla Asignada
* **Carlos Viza:** Módulo de Roles (`RolesController`, modelo `Rol`, persistencia en PostgreSQL).

## Estructura del Proyecto
BedrockHostProyecto/
    contructor.yml
    despliegue.yml
    .gitignore
    .env.example
    README.md
    BedrockHostAPI/
        BedrockHostAPI.csproj
        Program.cs
        Dockerfile
        Controllers/
        Models/
        Data/

## Pasos de Ejecución Local (con contructor.yml)
1. Clonar el repositorio y ubicarse en la raíz del proyecto.
2. Levantar los contenedores construyendo desde el código fuente:
   ```bash
   docker compose -f contructor.yml up --build


# BedrockHostAPI - Sistema de Gestión de Hosting de Servidores

API RESTful desarrollada en **.NET 10** con **Entity Framework Core** y **PostgreSQL**, completamente contenerizada con **Docker** y publicada en **Docker Hub**.

---

## 📦 Repositorio en Docker Hub

* **URL del Repositorio:** [https://hub.docker.com/r/dreadvorte/bedrock-hosting](https://hub.docker.com/r/dreadvorte/bedrock-hosting)
* **Imagen Oficial:** `dreadvorte/bedrock-hosting:latest`

---

## 🚀 Opción 1: Despliegue en Producción (Desde Docker Hub)

Esta opción descarga la imagen precompilada directamente desde **Docker Hub** y levanta la base de datos **PostgreSQL** sin necesidad de compilar el código fuente.

1. **Descargar la imagen desde Docker Hub:**
   ```bash
   docker pull dreadvorte/bedrock-hosting:latest