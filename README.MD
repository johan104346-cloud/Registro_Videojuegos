# RegistroVideojuegos - ADO.NET y SQLite

## Descripcion

Aplicacion de consola desarrollada en C# que permite demostrar el funcionamiento de ADO.NET mediante una conexion con una base de datos SQLite.

El proyecto permite crear una base de datos, generar una tabla, insertar registros y consultar la informacion almacenada.

## Tecnologias utilizadas

- C#
- .NET
- ADO.NET
- SQLite
- Microsoft.Data.Sqlite

## Funcionalidades

- Crear automaticamente una base de datos SQLite.
- Crear la tabla Videojuegos.
- Insertar tres videojuegos.
- Evitar registros duplicados.
- Consultar los videojuegos almacenados.
- Mostrar los resultados en consola.

## Estructura del proyecto

RegistroVideojuegos/
│
├── Program.cs
├── RegistroVideojuegos.csproj
├── videojuegos.db
└── README.md


## Instalacion y ejecucion

1. Clonar el repositorio:
```bash
git clone URL_DEL_REPOSITORIO

2. Entrar a la carpeta:
cd RegistroVideojuegos

3. Instalar el paquete:
dotnet add package Microsoft.Data.Sqlite

4. Ejecutar el proyecto:
dotnet run

La base de datos se crea automaticamente al ejecutar el programa.


## Objetivo 

Demostrar el uso de ADO.NET para conectar aplicaciones C# con SQLite, ejecutar instrucciones SQL y recuperar información mediante DataReader.