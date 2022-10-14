# Arquitectura Básica en Capas con .Net :nerd_face:
Proyecto para fines educativos, con el objetivo de enseñar la estructura de una arquitectura en capas; además de aplicar buenas prácticas, patrones de diseño, parametrización, inyección de dependencias, pruebas unitarias. El workflow es basicamente un CRUD de empleados en relación con el cargo asignado.

## Backup de la Base de datos
En el proyecto hay un archivo que corresponde al backup de la base de datos utilizada. El nombre es `Capas.Net.bak`

## Mapear tablas de la base de datos a entidades de clases en C#
Si bien es cierto que se puede hacer de `forma manual`, tambien se puede utilizar `migraciones`, pero en este caso, aplicaremos `scaffold`, solo abre el Package Manager Console de Visual Studio y ejecuta el siguiente comando:
```cmd
Scaffold-DbContext "Server=...;Database=Capas.Net;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer
```
Si deseas conocer mas parámetros del comando, ve al siguiente enlace ([Scaffold-DbContext Parameters](https://learn.microsoft.com/en-us/ef/core/cli/powershell#scaffold-dbcontext)).

## Modificar la cadena de conexión
Para ello deberas abrir el archivo `appsettings.json` ubicado en el proyecto web, donde el valor del parámetro `Server`, cambialo por el nombre de tu servidor de base de datos.
```json
"ConnectionStrings": {
  "Default": "Server=...;Database=Capas.Net;Trusted_Connection=True;"
}
```
