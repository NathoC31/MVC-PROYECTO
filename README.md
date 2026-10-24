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
### Maestro
- Id
- Nombre
- Apellido
- Materia
- Título
### Aula
- Id
- Código
- Capacidad
- Ubicación
- Tipo
### Libro
- Id
- Título
- Autor
- Editorial
- Año de Publicación


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

## Pasos para Ejecutar el Proyecto

### 1. Clonar el repositorio

```bash
git clone URL_DEL_REPOSITORIO
```

### 2. Abrir la solución

Abrir el archivo:

```text
MVC-Proyecto1.sln
```

### 3. Restaurar dependencias

```bash
dotnet restore
```

### 4. Crear la base de datos

En la Consola del Administrador de Paquetes ejecutar:

```powershell
Update-Database
```

### 5. Ejecutar la aplicación

```bash
dotnet run
```

o presionar:

```text
F5
```

## Funcionalidades
Cada entidad cuenta con:
- Crear
- Listar
- Ver detalles
- Editar
- Eliminar
## Repositorio
Enlace del repositorio de GitHub:
```text
https://github.com/NathoC31/MVC-PROYECTO
```
