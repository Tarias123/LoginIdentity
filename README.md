# 🚀 Product Management System API (.NET 8)

Esta es una Web API robusta y escalable diseñada para la gestión de productos, integrando un sistema de seguridad avanzado y siguiendo las mejores prácticas de arquitectura de software.

---

## 🛠️ Tecnologías y Herramientas

* **Backend:** ASP.NET Core Web API (.NET 8)
* **Persistencia:** Entity Framework Core
* **Base de Datos:** SQL Server
* **Seguridad:** ASP.NET Core Identity (Autenticación basada en Tokens/Cookies)
* **Patrones de Diseño:** Repository Pattern & Dependency Injection
* **Documentación:** Swagger / OpenAPI

---

## 🏗️ Arquitectura y Características Principales

### 🔐 Seguridad con Identity
* **Gestión de Usuarios:** Implementación de endpoints nativos para registro e inicio de sesión.
* **Protección de Endpoints:** Uso estratégico del atributo `[Authorize]` para asegurar operaciones sensibles.
* **Control de Acceso:** Configuración de middleware para validación de identidad en el flujo de peticiones.

### 🏛️ Diseño de Software
* **Repository Pattern:** Implementación de interfaces (`IProductRepo`) para desacoplar la lógica de acceso a datos del controlador, facilitando el mantenimiento y las pruebas unitarias.
* **Inyección de Dependencias:** Gestión centralizada de servicios en `Program.cs` para una mejor gestión del ciclo de vida de los objetos.
* **Validaciones:** Uso de `DataAnnotations` para garantizar la integridad de los datos de entrada.

### 📦 Funcionalidades CRUD
* Lectura pública de productos con ordenamiento lógico.
* Creación, actualización y eliminación de registros restringida a usuarios autenticados.

---

## ⚙️ Configuración e Instalación

1.  **Clonar el repositorio:**
    ```bash
    git clone [https://github.com/tu-usuario/nombre-del-repo.git](https://github.com/tu-usuario/nombre-del-repo.git)
    ```

2.  **Configurar Base de Datos:**
    Actualiza la cadena de conexión en el archivo `appsettings.json`:
    ```json
    "ConnectionStrings": {
      "ConexionSQL": "Server=TU_SERVIDOR;Database=LoginIdentity;Trusted_Connection=True;TrustServerCertificate=True"
    }
    ```

3.  **Ejecutar Migraciones:**
    Genera las tablas de Identity y Productos en tu servidor local:
    ```bash
    dotnet ef database update
    ```

4.  **Iniciar Aplicación:**
    Ejecuta el proyecto y accede a `.../swagger` para interactuar con la API.

---

## 📝 Autor
Desarrollado por **Ángel Tapia** - *FullStack Developer Enthusiast*
