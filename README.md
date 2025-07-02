# GS.PrototipoCodex

Este proyecto es un prototipo de API REST desarrollada con **ASP.NET Core**. Contiene un conjunto de endpoints de ejemplo para la gestión de tareas y algunos recursos de utilidad.

## Requisitos
- .NET 8 SDK

## Compilación y ejecución

Ejecute el siguiente comando para iniciar la aplicación desde la raíz del repositorio:

```bash
dotnet run --project GS.PrototipoCodex
```

Al iniciar en modo de desarrollo, la API expone documentación interactiva mediante **Swagger** en `https://localhost:port/swagger`.

## Estructura del proyecto
- **Controllers**: Controladores que definen los endpoints.
- **DTOs**: Objetos de transferencia de datos utilizados por la API.
- **Models**: Modelos de dominio.
- **Repositories**: Implementación de repositorios para acceder a datos (actualmente en memoria).

## Endpoints principales

### /api/tasks
- `GET /api/tasks` – Obtiene todas las tareas.
- `GET /api/tasks/{id}` – Obtiene una tarea específica.
- `POST /api/tasks` – Crea una nueva tarea.
- `PUT /api/tasks/{id}/complete` – Marca una tarea como completada.
- `DELETE /api/tasks/{id}` – Elimina una tarea.

### /api/utils
- `GET /api/utils/health` – Verifica la salud de la aplicación.
- `GET /api/utils/time` – Devuelve la hora del servidor.
- `GET /api/utils/version` – Devuelve la versión ensamblada.

### /weatherforecast
Endpoint de ejemplo generado por plantilla.

## Notas
- Los datos se almacenan en memoria a través de `InMemoryTaskRepository`.
- La generación de documentación XML está habilitada en el proyecto.
