# MVC-PROYECTO

# Sistema de Gestión Escolar

Aplicación web desarrollada con ASP.NET Core MVC, Entity Framework Core y SQL Server para la gestión de entidades escolares mediante operaciones CRUD.

## Integrantes

| Integrante | Entidad |
|------------|----------|
| Henry Borja | Estudiante |
| Nathaly Cuasapaz | Maestro |
| Pablo Loya | Aula |
| Santiago Loya | Libro |

## Tecnologías Utilizadas

- ASP.NET Core MVC (.NET 10)
- Entity Framework Core
- SQL Server Express
- SQL Server Management Studio (SSMS)
- GitHub
- Visual Studio 2026

## Entidades Implementadas
### Estudiante
- Id
- Nombre
- Apellido
- Correo
- Edad

## Configuración de Base de Datos
Abrir el archivo:
appsettings.json
```json
{
    "ConnectionStrings": {
    "UEESGContext": "Server=localhost\\SQLEXPRESS;Database=UEESG_BD;Trusted_Connection=True;MultipleActiveResultSets=true; TrustServerCertificate=true;"
  }
}
```
## Funcionalidades
Cada entidad cuenta con:
- Crear
- Listar
- Ver detalles
- Editar
- Eliminar
## Repositorio
Agregar aquí el enlace del repositorio de GitHub:
```text
https://github.com/NathoC31/MVC-PROYECTO
```
