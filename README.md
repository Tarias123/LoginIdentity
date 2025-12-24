🚀 Sistema de Gestión de Productos con Auth (.NET 8)
Este proyecto es una Web API robusta desarrollada con .NET 8 que implementa un sistema completo de gestión de productos, integrando seguridad avanzada mediante ASP.NET Core Identity.

🛠️ Tecnologías y Herramientas
Backend: .NET 8 (ASP.NET Core Web API)
Persistencia: Entity Framework Core
Base de Datos: SQL Server
Seguridad: ASP.NET Core Identity (Autenticación basada en Tokens/Cookies)
Patrones de Diseño: Repository Pattern (Desacoplamiento de lógica de datos)

🏗️ Arquitectura y Características
Implementación de Identity: Manejo automático de registro de usuarios, inicio de sesión y protección de endpoints mediante el atributo [Authorize].
Repository Pattern: Uso de interfaces (IProductRepo) para asegurar un código mantenible, testeable y desacoplado del controlador.
Inyección de Dependencias: Configuración centralizada de servicios en el Program.cs.
Validaciones de Modelo: Uso de DataAnnotations para asegurar la integridad de los datos antes de persistirlos en la base de datos.
Operaciones CRUD: Implementación completa para la gestión de productos.


⚙️ Configuración del Proyecto
Clonar el repositorio.
Configurar la cadena de conexión en el archivo appsettings.json.
Ejecutar las migraciones para generar la base de datos
