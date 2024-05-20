OJO: Al momento de alguien bajar los cambios debe de cambiar solamente del appsettings.json (en el proyecto de WebApi)
el IdentityConnection y el DefaultConnetion con la ruta de su base de datos, luego vas a Package Manager Console y
en la opción que dice Default Projects lo vas a poner primero en la capa de identity y vas a escribir: Update-Database -Context IdentityContext,
Lo mismo vas hacer con la capa de persistence, vas a cambiar de la capa de identity a persistencia y en el panel de escritura vas a escribir: Update-Database -Context ApplicationContext.
Sino haces estos cambios no te va a funcionar la app y te va a dar un error de mapeo con la base de datos.

Resumen de la Funcionalidad de la Aplicación
Objetivo General
Crear una API para una aplicación de comida de un restaurante, utilizando ASP.NET Core MVC 6 o 7.

Funcionalidades Generales

Login y Seguridad:

Dos roles: Administrador y Mesero.
Seguridad en los endpoints mediante JWT.
Creación por defecto de roles y usuarios (Administrador, Mesero, y Super Administrador).
Controlador AccountController con funcionalidades de login, registro de usuarios meseros y administradores.
Usuarios creados activos, sin confirmación de cuenta.
Validación de acceso a funcionalidades según roles utilizando filtros de autorización de Identity con JWT.
Mensajes de error y códigos de estado apropiados para accesos no autorizados (401) y acceso denegado (403).
Mantenimiento de Ingredientes:

Datos: Id, Nombre.
Endpoints: Crear, Actualizar, Listar, Obtener por Id.
Solo accesibles por el rol Administrador.
Mantenimiento de Platos:

Datos: Id, Nombre, Precio, Porciones, Ingredientes, Categoría (Entrada, Plato fuerte, Postre, Bebida).
Endpoints: Crear, Actualizar, Listar, Obtener por Id.
Solo accesibles por el rol Administrador.
Mantenimiento de Mesas:

Datos: Id, Capacidad, Descripción, Estado (Disponible, En proceso de atención, Atendida).
Endpoints: Crear, Actualizar, Listar, Obtener por Id, Obtener órdenes, Cambiar estado.
Accesibles por roles Administrador y Mesero (con ciertas restricciones).
Mantenimiento de Órdenes:

Datos: Id, Mesa, Platos, Subtotal, Estado (En proceso, Completada).
Endpoints: Crear, Actualizar, Listar, Obtener por Id, Eliminar.
Solo accesibles por el rol Mesero.
Requerimientos Técnicos

Uso de viewmodels y validaciones realizadas desde los mismos.
Persistencia de datos mediante Entity Framework con code first.
Arquitectura ONION aplicada correctamente.
Uso de repositorios y servicios genéricos.
Identity para el manejo de usuarios y seguridad con JWT.
AutoMapper para el mapeo de viewmodels, entidades y dtos.
Descripción del Proyecto en Readme
Descripción del Proyecto

Este proyecto implementa una API para una aplicación de comida de un restaurante, permitiendo gestionar usuarios, ingredientes, platos, mesas y órdenes. La aplicación está desarrollada utilizando ASP.NET Core MVC y sigue la arquitectura ONION para asegurar una alta mantenibilidad y separación de preocupaciones.

Tecnologías Utilizadas

ASP.NET Core MVC (versiones 6 o 7): Framework principal para la construcción de la aplicación.
Entity Framework Core: Para la persistencia de datos utilizando el enfoque code first.
JWT (JSON Web Tokens): Para la autenticación y autorización segura de los usuarios.
AutoMapper: Para mapeo entre objetos de dominio, viewmodels y dtos.
Arquitectura ONION: Para una clara separación de las capas de la aplicación y mejorar la mantenibilidad y testabilidad del código.
Funcionalidades Clave

Autenticación y Autorización: Sistema de login y registro con roles de administrador y mesero, utilizando JWT para la seguridad.
Gestión de Ingredientes: CRUD de ingredientes, accesible solo por administradores.
Gestión de Platos: CRUD de platos, accesible solo por administradores.
Gestión de Mesas: CRUD de mesas y cambio de estado, accesible por administradores y meseros con restricciones.
Gestión de Órdenes: CRUD de órdenes, accesible solo por meseros.
Seguridad: Acceso restringido a funcionalidades según roles de usuario, con validaciones y respuestas de error apropiadas.
Requerimientos Técnicos

Viewmodels: Utilizados para la validación de datos en las solicitudes.
Entity Framework: Persistencia de datos mediante code first.
Arquitectura ONION: Aplicación correcta para asegurar una clara separación de las capas.
Repositorios y Servicios Genéricos: Implementados para la gestión de datos.
Identity: Manejo de usuarios y seguridad con JWT.
AutoMapper: Para el mapeo eficiente de datos entre entidades y dtos.
Este proyecto proporciona una base sólida para una API funcional de un restaurante, con un enfoque en la seguridad, la validación de datos y la usabilidad.
