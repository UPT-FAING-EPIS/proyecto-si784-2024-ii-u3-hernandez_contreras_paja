<center>

[comment]: <img src="./media/media/image1.png" style="width:1.088in;height:1.46256in" alt="escudo.png" />

![./media/media/image1.png](./media/logo-upt.png)

**UNIVERSIDAD PRIVADA DE TACNA**

**FACULTAD DE INGENIERIA**

**Escuela Profesional de Ingeniería de Sistemas**

**Proyecto *“Control de Asistencia”***

Curso: *Calidad y Pruebas de Software*

Docente: *Ing. Cuadros Quiroga, Patrick Jose*

Integrantes:

***
Paja De la Cruz, Piero Alexander			(2020067576)

Contreras Lipa, Alvaro Javier 			(2021070020)

Hernández Cruz, Angel Gadiel		 	(2021070017)
***

**Tacna – Perú**

***2024***

**  
**
</center>
<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

Sistema *{Nombre del Sistema}*

Informe de Factibilidad

Versión *{1.0}*

|CONTROL DE VERSIONES||||||
| :-: | :- | :- | :- | :- | :- |
|Versión|Hecha por|Revisada por|Aprobada por|Fecha|Motivo|
|1\.0|MPV|ELV|ARV|10/10/2020|Versión Original|

<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

# **INDICE GENERAL**

Resumen

Abstract

[1. Antecedentes](#_Toc52661346)

[2. Titulo](#_Toc52661347)

[3. Autores](#_Toc52661348)

[4. Planteamiento del problema](#_Toc52661349)

[4.1 Problema](#_Toc52661350)

[4.2 Justificación](#_Toc52661351)

[4.3 Alcance](#_Toc52661352)

[5. Objetivos](#_Toc52661356)

[5.1 General](#_Toc52661350)

[5.2 Especificos](#_Toc52661351)

[6. Referentes teóricos](#_Toc52661357)

[7. Desarrollo de la propuesta](#_Toc52661356)

[7.1 Tecnología de información ](#_Toc52661350)

[7.2 Metodología, técnicas usadas](#_Toc52661351)

[7. Cronograma](#_Toc52661356)


<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

**<u>Tema: Control de Asistencia</u>**

1. <span id="_Toc52661346" class="anchor"></span>**Antecedentes o introducción**

    Cuando el usuario ingresa sus datos para iniciar sesión en la interfaz del sistema de control de asistencia, se le asignará un rol según su nivel de relevancia dentro del sistema (por ejemplo, usuario común, administrador, supervisor). Esta información se almacenará en una base de datos creada anteriormente, asegurando que los nombres de usuario y contraseñas sean únicos. 

2. <span id="_Toc52661347" class="anchor"></span>**Titulo**

    Control Asistencia

3. <span id="_Toc52661348" class="anchor"></span>**Autores**

* Contreras Lipa, Alvaro Javier
* Hernandez Cruz, Angel Gadiel
* Paja De la Cruz, Piero Alexander

4. <span id="_Toc52661349" class="anchor"></span>**Planteamiento del problema**

    4.1. <span id="_Toc52661350" class="anchor"></span>Problema

    La problemática que motiva la implementación de la codificación en el sistema de control de asistencia es la privacidad de los usuarios. La protección de datos como el DNI, número telefónico e incluso los nombres genera preocupación, por lo que se optó por codificar toda la información. De esta manera, solo podrán acceder a los datos aquellos que estén autorizados y tengan una relación directa con el empleado registrado.

    4.2. <span id="_Toc52661351" class="anchor"></span>Justificación

    La implementación de la codificación en el sistema de control de asistencia se justifica principalmente para proteger la privacidad de los usuarios, asegurando que datos sensibles como el DNI, número telefónico y nombres estén resguardados. Esta medida responde a la necesidad de prevenir el acceso no autorizado y posibles usos indebidos de la información personal, garantizando que solo personas directamente relacionadas con el empleado registrado puedan acceder a estos datos. De este modo, se preserva la confidencialidad y se cumple con las normativas de protección de datos personales, evitando controversias y posibles daños a los individuos involucrados.

    4.3. <span id="_Toc52661352" class="anchor"></span>Alcance

    El alcance principal del sistema está limitado únicamente a personas autorizadas que cuenten con un usuario registrado, garantizando así que no haya divulgación o filtración de información.

5. <span id="_Toc52661356" class="anchor"></span>**Objetivos**

    5.1. General

    El objetivo principal es un diseño minimalista que proporcione un ambiente amigable, permitiendo al usuario acceder y utilizar el sistema con facilidad, así como ingresar o encontrar rápidamente los datos necesarios.

    5.2. Especifico
   
    * Evitar la vulneración de contraseñas mediante ataques de diccionario.
    * Prevenir la exposición de datos personales.
    * Facilitar la navegación en relación con los usuarios registrados.

6. <span id="_Toc52661357" class="anchor"></span>**Referentes teóricos**
    Diagramas de Casos de Uso, Diagrama de Clases, Diagrama de Componentes y Arquitectura.

**REQUERIMIENTOS FUNCIONALES**

- **RF1**: Autenticación: El sistema debe permitir el inicio de sesión mediante un nombre de usuario y contraseña. **(Prioridad: Alta)**
- **RF2**: Validación de Usuario: El sistema debe verificar la validez del usuario y contraseña utilizando un procedimiento almacenado. **(Prioridad: Alta)**
- **RF3**: Gestión de Empleados: El sistema debe permitir agregar, modificar y eliminar empleados. **(Prioridad: Alta)**
- **RF4**: Visualización de Empleados: El sistema debe listar todos los empleados registrados en un DataGridView. **(Prioridad: Alta)**
- **RF5**: Marcar Asistencia: El sistema debe permitir marcar la asistencia de un empleado usando su nombre y DNI. **(Prioridad: Alta)**
- **RF6**: Listado de Asistencias: El sistema debe mostrar las asistencias marcadas por día. **(Prioridad: Alta)**
- **RF7**: Obtener Faltas: El sistema debe permitir obtener las faltas de los empleados. **(Prioridad: Media)**
- **RF8**: Configuración de Áreas y Puestos: El sistema debe permitir seleccionar áreas y puestos desde un combo box. **(Prioridad: Media)**
- **RF9**: Interacción de UI: El sistema debe proporcionar retroalimentación visual (ej. cambio de color al pasar el mouse) para mejorar la experiencia del usuario. **(Prioridad: Media)**
- **RF10**: Limpiar Campos: El sistema debe permitir limpiar los campos de entrada después de realizar una acción. **(Prioridad: Media)**


**DEFINICIÓN, SIGLAS Y ABREVIATURAS**

**Definiciones:**
- **LOGIN**: Proceso de autenticación para usuarios y administradores en el sistema.
- **FrmAsistencias**: Formulario para marcar y gestionar la asistencia de los empleados.
- **FrmEmpleado**: Formulario dedicado a la gestión de información de los empleados, incluyendo agregar, modificar y eliminar registros.
- **FrmEstadisticas**: Formulario que muestra estadísticas relacionadas con la asistencia de los empleados.
- **FrmInicio**: Pantalla principal del sistema que ofrece acceso a diferentes funcionalidades y opciones.
- **FrmLista**: Formulario que muestra una lista de empleados registrados y permite la selección para ver detalles o realizar acciones.

**Siglas y Abreviaturas:**
- **UI (User Interface)**: Interfaz de usuario que debe ser intuitiva y fácil de usar.
- **DB (Database)**: Base de datos utilizada por el sistema para almacenar información de los empleados y sus asistencias.
- **CRUD (Create, Read, Update, Delete)**: Conjunto de operaciones básicas para la gestión de datos en la base de datos.

**DIAGRAMA DE PAQUETES**

![paquetes](./media/paquetesv2.png)

**DIAGRAMA ENTIDAD-RELACIÓN**

![entidad-relacion](./media/entidad-relacionv2.png)

**DIAGRAMA DE CLASES**

![clases](./media/clasesv2.png)

**DIAGRAMA DE SECUENCIA**

![secuencia](./media/secuenciav2.png)

**DIAGRAMA DE CASOS DE USO**

![casos-de-uso](./media/casos-de-usov2.png)

**DIAGRAMA DE COMPONENTES**

![componentes](./media/componentesv2.png)

**DIAGRAMA DE DESPLIEGUE**

![despliegue](./media/desplieguev2.png)


7. Desarrollo de la propuesta 

SONARCLOUD

![sonar-1](./media/sonar-1.png)

Versión Corregida (Con soporte asincrónico):

![sonar-1.1](./media/sonar-1.1.png)

**Descripción de los cambios:**

**Cambio de Run() a RunAsync():**

* En el código antiguo, el método app.Run() se utilizaba de manera sincrónica, lo que no es eficiente para aplicaciones que manejan múltiples solicitudes concurrentes. Ahora, se usa await app.RunAsync() para permitir que la aplicación se ejecute de forma asincrónica, mejorando la capacidad de respuesta de la aplicación.

**Método principal async Task Main:**

* El método principal se ha modificado para ser asincrónico, utilizando async Task Main en lugar de solo void Main. Esto permite el uso de await en el código principal del programa, lo que es necesario para las operaciones asincrónicas.

**Uso de Task.FromResult en el endpoint:**

* El uso de Task.FromResult con await es un patrón que prepara la aplicación para operaciones asincrónicas en endpoints. Aún si el resultado es inmediato, este enfoque permite evitar bloqueos y manejar de forma efectiva operaciones de larga duración, mejorando el rendimiento de la aplicación al escalar con múltiples solicitudes concurrentes. 

![sonar-2](./media/sonar-2.png)

Código Corregido:

![sonar-2.1](./media/sonar-2.1.png)

**Descripción de los cambios:**

**Añadido de un Espacio de Nombres (namespace):**

* Se añadió la declaración namespace ControlAsistencia para encapsular la clase Program. 

**Imports Necesarios:**

* Se han añadido las declaraciones using para importar los namespaces de Microsoft.AspNetCore.Builder y Microsoft.Extensions.DependencyInjection, que son necesarios para el funcionamiento del código.

<br>

**Move 'Program' into a named namespace**

**Código Corregido:**

![sonar-3](./media/sonar-3.png)

**Descripción de los cambios:** 

* Eliminación de TemperatureF: Se ha removido la propiedad TemperatureF del record WeatherForecast, ya que no se utilizaba en el código. Esto ayuda a reducir la complejidad y mejora la mantenibilidad del código.

<br>

**Snyk:**

no se encontraron errores en el código

![snyk](./media/snyk.png)


## **Reporte de Cobertura de Pruebas Unitarias**

El objetivo del reporte de cobertura es evaluar qué porcentaje del código fuente ha sido ejecutado durante las pruebas automatizadas, ayudando a identificar áreas no probadas, garantizar la calidad del software, fomentar pruebas más exhaustivas y guiar el mantenimiento del código. Proporciona métricas claras para medir el progreso de las pruebas y priorizar esfuerzos en áreas críticas, reduciendo el riesgo de errores y asegurando que el software sea más robusto y confiable.

![reporte_cobertura](./media/reporte_cobertura_1.jpg)
![reporte_cobertura](./media/reporte_cobertura_2.jpg)

### **Tests Creados**

![controller_tests](./media/controller_tests.png)

1. HomeControllerTests.cs **Mock**
* Objetivo: Verificar las funcionalidades clave del controlador HomeController.
* Cobertura de pruebas:
    * Método Error: Asegura que el método Error retorna un ViewResult con un modelo de tipo ErrorViewModel y valida el TraceIdentifier proporcionado.
    * Validación del modelo: Comprueba que el modelo del resultado tiene los datos esperados, lo cual confirma que el controlador procesa correctamente los errores.

2. AdminControllerTests.cs
* Objetivo: Probar las funcionalidades principales del controlador AdminController, incluyendo la gestión de empleados, asistencias, historial de cambios y reportes.
* Cobertura de pruebas:
    * Dashboard: Valida que los datos en ViewBag (total de empleados, asistencias, presentes, ausentes) se calculan correctamente en diferentes escenarios.
    * Gestión de empleados y asistencias: Comprueba que las vistas GestionEmpleados y GestionAsistencias cargan las listas adecuadas de empleados y asistencias respectivamente.
    * AgregarEmpleado: Verifica tanto los casos válidos como inválidos de agregar un empleado.
    * Reportes: Asegura que los datos de asistencia por mes, presentes y ausentes son calculados y mostrados correctamente.

3. AsistenciaControllerTests.cs
* Objetivo: Validar las acciones del controlador AsistenciaController relacionadas con la gestión de asistencias e historial.
* Cobertura de pruebas:
    * Métodos Index e Historial: Verifica que retornan correctamente una vista.
    * Registrar asistencia: Comprueba que el registro de asistencia (tanto con solicitudes GET como POST) funciona correctamente y retorna los resultados esperados.
    * Setup: Asegura que el controlador se inicializa correctamente.

4. EmpleadoControllerTests.cs
*   Objetivo: Validar las funcionalidades del controlador EmpleadoController, especialmente en la gestión de empleados.
*   Cobertura de pruebas:
    * AgregarEmpleado: Valida tanto los casos de éxito como los errores en el registro de empleados (por ejemplo, cuando el modelo es inválido).
    * VerEmpleados: Comprueba que la lista de empleados se carga correctamente.
    * Actualización de la lista: Asegura que, tras agregar un empleado, la lista se actualiza adecuadamente y refleja los cambios esperados.

5. AsistenciaControllerTests2.cs
* Objetivo: Validar funcionalidades adicionales del controlador AsistenciaController relacionadas con el manejo de asistencias y vistas complementarias.
* Cobertura de pruebas:
    * Index: Comprueba que el método retorna una vista con el modelo esperado de tipo List<Asistencia>.
    * RegistrarAsistencia (GET): Valida que se retorna una vista con la lista de empleados en el ViewData.
    * RegistrarAsistencia (POST):
        * Caso exitoso: Verifica que una asistencia se agrega correctamente cuando el empleado existe, redirigiendo al método Historial.
        * Caso fallido: Valida que retorna un BadRequest con un mensaje adecuado cuando el empleado no es encontrado.
    * Historial: Asegura que retorna una vista con un modelo de tipo List<Asistencia>.



![model_tests](./media/model_tests.png)


1. Administrador.Tests.cs
* Objetivo: Evaluar las funcionalidades principales del modelo Administrador, verificando que sus propiedades se comporten correctamente y cumplan con las reglas de validación.
* Cobertura de pruebas:
    * Propiedades: Se verifican los métodos de acceso (get y set) de las propiedades del modelo Administrador.
    * Validación: Asegura que los datos cumplen con las restricciones definidas en las anotaciones de validación.
    * Caso inválido: Prueba un escenario en el que una propiedad requerida no está configurada, validando que el modelo no sea válido.


1. Administrador.Tests.cs
* Objetivo: Evaluar las funcionalidades principales del modelo Administrador, verificando que sus propiedades se comporten correctamente y cumplan con las reglas de validación.
* Cobertura de pruebas:
Propiedades: Se verifican los métodos de acceso (get y set) de las propiedades del modelo Administrador.
Validación: Asegura que los datos cumplen con las restricciones definidas en las anotaciones de validación.
Caso inválido: Prueba un escenario en el que una propiedad requerida no está configurada, validando que el modelo no sea válido.

2. Asistencia.Tests.cs
* Objetivo: Validar la integridad y el comportamiento del modelo Asistencia, asegurando la correcta gestión de sus propiedades y su cumplimiento con las reglas de validación.
* Cobertura de pruebas:
    * Asignación de Propiedades: Verifica que las propiedades como Id, EmpleadoId, Empleado, Fecha y Estado se asignen y se obtengan correctamente.
    * Validación Exitosa: Comprueba que el modelo es válido cuando todas las propiedades requeridas están configuradas adecuadamente.
    * Caso Inválido: Valida que el modelo sea inválido cuando una propiedad requerida como Empleado es nula y revisa los mensajes de error generados.

3. ErrorViewModelTests.cs
* Objetivo: Evaluar el comportamiento de la propiedad ShowRequestId del modelo ErrorViewModel.
* Cobertura de pruebas:
    * Caso Nulo: Verifica que ShowRequestId devuelve false cuando RequestId es nulo.
    * Caso Vacío: Confirma que ShowRequestId retorna false cuando RequestId está vacío.
    * Caso Válido: Asegura que ShowRequestId devuelve true cuando RequestId contiene un valor válido.

![view_tests](./media/view_test.png)

1. AdminViewTest.cs
* Objetivo: Validar el correcto funcionamiento de las vistas relacionadas con la administración en el proyecto.
* Cobertura de pruebas:
    * AgregarEmpleadoModel: Verifica que la página se carga sin lanzar excepciones.
    * DashboardModel: Valida que la vista del dashboard se cargue correctamente.
    * GestionAsistenciasModel: Asegura que la lista de asistencias se gestione correctamente y simula datos para verificar la funcionalidad.
    * GestionEmpleadosModel: Comprueba la correcta carga de la vista de gestión de empleados.
    * HistorialCambiosModel: Valida la funcionalidad de historial de cambios y su manejo cuando no hay datos.
    * ReportesModel: Verifica que la vista de reportes se cargue sin errores.
    * VerEmpleadosModel: Comprueba que la lista de empleados se muestre correctamente en la vista y su manejo cuando no hay datos.

2. AsistenciaViewTest.cs
* Objetivo: Validar las vistas relacionadas con la gestión de asistencias en el proyecto.
* Cobertura de pruebas:
    * AgregarAsistenciaModel: Comprueba que la vista de agregar asistencia se cargue correctamente y valida la funcionalidad para agregar datos.
    * FiltrarPorFechaModel: Valida que la funcionalidad de filtrado por fecha en la vista opere sin errores.
    * HistorialModel: Asegura que la vista del historial se carga correctamente.
    * ConfirmacionModel: Verifica que la página de confirmación funcione correctamente, incluyendo la simulación de éxito en la operación.

3. EmpleadoViewTest.cs
* Objetivo: Garantizar que las vistas relacionadas con los empleados funcionen correctamente.
* Cobertura de pruebas:
    * AgregarEmpleadoModel: Valida que la vista se cargue y que los empleados puedan ser añadidos correctamente.
    * DetallesModel: Comprueba que los detalles de un empleado se carguen correctamente.
    * IndexModel: Valida que la lista de empleados se cargue correctamente en la vista de índice y simula datos para verificar el conteo y contenido.

4. HomeViewTest.cs **Mock**
* Objetivo: Validar las funcionalidades principales de las vistas de inicio y privacidad.
* Cobertura de pruebas:
    * Index: Comprueba que el método Index devuelve un resultado de tipo ViewResult.
    * Privacy: Verifica que el método Privacy también devuelve un resultado de tipo ViewResult.

5. ErrorViewModelTests.cs
* Objetivo: Validar la funcionalidad del modelo ErrorViewModel en la gestión de identificadores de solicitud (RequestId).
* Cobertura de pruebas:
    * ShowRequestId (true): Comprueba que ShowRequestId retorna verdadero cuando RequestId no es nulo ni vacío.
    * ShowRequestId (false): Valida que ShowRequestId retorna falso cuando RequestId es nulo o vacío.

6. IndexModelTests.cs
* Objetivo: Validar el correcto funcionamiento de la página de inicio (Index) del módulo de asistencia.
* Cobertura de pruebas:
    * OnGet: Verifica que la ejecución del método OnGet no genera excepciones.

7. RegistrarAsistenciaModelTests.cs
* Objetivo: Asegurar que el modelo de la vista para registrar asistencias opera correctamente.
* Cobertura de pruebas:
    * OnGet: Valida que el método OnGet no arroje excepciones durante su ejecución.

## **Reporte de Pruebas mutantes**
![view_tests](./media/mutantes_all.png)
* Killed (65): Mutantes eliminados por las pruebas. Tus pruebas lograron detectar los errores introducidos en estas 65 mutaciones.

* Survived (24): Mutantes que sobrevivieron. Esto significa que tus pruebas no detectaron los errores introducidos y no fallaron. Estas son áreas donde tus pruebas necesitan mejorar.

* Timeout (0): No hubo casos en los que las pruebas excedieran el tiempo de ejecución permitido.

* No Coverage (12): Mutantes que no fueron alcanzados por ninguna prueba. Esto indica código no cubierto.

* Ignored (20): Mutantes ignorados por filtros internos (por ejemplo, mutantes en bloques ya cubiertos).

* Compile Errors (14): Mutantes que causaron errores de compilación y no pudieron ser probados.
![view_tests](./media/mutantes_controller.png)
### Controllers:
* Puntaje total: 73.02%
* De los cubiertos: 85.19%
* Mutantes totales: 90
* 46 Killed: Buen resultado, pero hay margen de mejora.
* 8 Survived: Estos indican áreas donde las pruebas no detectaron mutaciones.
* 9 No Coverage: Hay partes del código en los controladores no alcanzadas por pruebas.
* 14 Compile Errors: Mutaciones en los controladores causaron errores de compilación.

![view_tests](./media/mutantes_model.png)
### Models:
* Puntaje total y cubierto: 77.78%
* Mutantes totales: 9
* 7 Killed: La mayoría de las pruebas cubrieron correctamente estas mutaciones.
* 2 Survived: Representan áreas donde las pruebas podrían mejorar.

![view_tests](./media/mutantes_view.png)
### Views:
* Puntaje total y cubierto: 62.50%
* Mutantes totales: 22
* 10 Killed: Las pruebas en las vistas están funcionando relativamente bien.
* 6 Survived: Algunas mutaciones no detectadas; se necesita mayor cobertura.
* 3 No Coverage: Hay código en las vistas no alcanzado por pruebas.


## **Reporte de Pruebas de Aceptación**	

## Propósito General:
Como desarrollador, se busca validar los modelos del proyecto para asegurar que los datos son válidos y cumplen con los requisitos definidos.

![view_tests](./media/pruebas_aceptacion.png)

## Escenarios de Validación:

### Escenario: Acceso a la página principal
- **Given:** Estoy en el cliente HTTP.
- **Then:** Realizo una petición GET a "/".
- **Resultado:** La página principal fue validada exitosamente, asegurando que responde con el código esperado (200).

![view_tests](./media/aceptacion_1.png)

### Escenario: Acceso a una página inexistente
- **Given:** Estoy en el cliente HTTP.
- **Then:** Realizo una petición GET a "/non-existing-page".
- **Resultado:** El sistema devolvió correctamente un código de respuesta 404, confirmando que las rutas inexistentes se manejan apropiadamente.

![view_tests](./media/aceptacion_2.png)

### Escenario: Acceso a la página de inicio de sesión
- **Given:** Estoy en el cliente HTTP.
- **Then:** Realizo una petición GET a "/login".
- **Resultado:** La página de inicio de sesión fue validada con éxito, asegurando que responde con el código esperado (200).

![view_tests](./media/aceptacion_3.png)

### Escenario: Envío de formulario sin datos
- **Given:** Estoy en el cliente HTTP.
- **Then:** Realizo una petición POST a "/submit-form" con datos vacíos.
- **Resultado:** El formulario fue correctamente rechazado, devolviendo el código de error esperado (400).

![view_tests](./media/aceptacion_4.png)

### Escenario: Acceso a la página de perfil
- **Given:** Estoy en el cliente HTTP.
- **Then:** Realizo una petición GET a "/profile".
- **Resultado:** La página de perfil fue validada exitosamente, asegurando que responde con el código esperado (200).

![view_tests](./media/aceptacion_5.png)

### Escenario: Envío de formulario con datos válidos
- **Given:** Estoy en el cliente HTTP.
- **Then:** Realizo una petición POST a "/submit-form" con datos válidos.
- **Resultado:** El formulario fue procesado correctamente, devolviendo un código de respuesta exitoso (200).

![view_tests](./media/aceptacion_6.png)

### Escenario: Eliminación de un registro inexistente
- **Given:** Estoy en el cliente HTTP.
- **Then:** Realizo una petición DELETE a "/delete/999".
- **Resultado:** La eliminación del registro inexistente fue validada correctamente, devolviendo el código esperado (404).

![view_tests](./media/aceptacion_7.png)

### Escenario: Acceso a la página de configuración
- **Given:** Estoy en el cliente HTTP.
- **Then:** Realizo una petición GET a "/settings".
- **Resultado:** La página de configuración fue validada exitosamente, asegurando que responde con el código esperado (200).

![view_tests](./media/aceptacion_8.png)

### Escenario: Actualización de un registro
- **Given:** Estoy en el cliente HTTP.
- **Then:** Realizo una petición PUT a "/update/1" con datos válidos.
- **Resultado:** La actualización del registro fue procesada correctamente, devolviendo un código de respuesta exitoso (200).

![view_tests](./media/aceptacion_9.png)

### Escenario: Consulta de un registro inexistente
- **Given:** Estoy en el cliente HTTP.
- **Then:** Realizo una petición GET a "/record/999".
- **Resultado:** La consulta del registro inexistente fue validada correctamente, devolviendo el código esperado (404).

![view_tests](./media/aceptacion_10.png)

### Escenario: Consulta de un registro válido
- **Given:** Estoy en el cliente HTTP.
- **When:** Realizo una petición GET a "/record/1".
- **Then:** Obtengo un código de respuesta exitoso.
- **Resultado:** La consulta al registro válido fue realizada correctamente, devolviendo un código 200.

![view_tests](./media/aceptacion_11.png)

### Escenario: Acceso a una API pública
- **Given:** Estoy en el cliente HTTP.
- **When:** Realizo una petición GET a "/api/public".
- **Then:** Obtengo un código de respuesta exitoso.
- **Resultado:** El acceso a la API pública fue validado con éxito, retornando un código de respuesta 200.

![view_tests](./media/aceptacion_12.png)

### Escenario: Intento de acceso no autorizado
- **Given:** Estoy en el cliente HTTP.
- **When:** Realizo una petición GET a "/admin".
- **Then:** Obtengo un código de respuesta 403.
- **Resultado:** La prueba confirmó que el acceso no autorizado está protegido, devolviendo el código esperado de prohibición (403).

![view_tests](./media/aceptacion_13.png)

### Escenario: Descarga de un archivo
- **Given:** Estoy en el cliente HTTP.
- **When:** Realizo una petición GET a "/download/file".
- **Then:** Obtengo un código de respuesta exitoso.
- **Resultado:** La descarga del archivo fue validada correctamente, con un código de respuesta 200.

![view_tests](./media/aceptacion_14.png)

### Escenario: Acceso a una API protegida sin token
- **Given:** Estoy en el cliente HTTP.
- **When:** Realizo una petición GET a "/api/private".
- **Then:** Obtengo un código de respuesta 401.
- **Resultado:** El acceso sin token a la API protegida fue bloqueado correctamente, devolviendo el código de error 401 por falta de autenticación.

![view_tests](./media/aceptacion_15.png)


## **SONAR CLOUD - Reporte de cobertura**

![view_tests](./media/coveragesonar_0.png)
![view_tests](./media/coveragesonar_1.png)

La cobertura de código en SonarCloud es una métrica clave que evalúa qué porcentaje del código de un proyecto está siendo probado mediante pruebas automatizadas. Este análisis permite identificar las partes del código que no han sido ejecutadas durante los tests, ayudando a mejorar la calidad del software al reducir errores no detectados.

* Cobertura General (Coverage):
Se alcanzó un 93.6% de cobertura general, lo que indica que la mayoría del código está siendo verificado mediante pruebas automatizadas.
Existen 10 líneas y 7 condiciones no cubiertas, lo que podría representar áreas del código que aún no han sido probadas.
* Line Coverage:
Específicamente, las líneas de código tienen una cobertura del 95.5%, lo que significa que casi todas las líneas han sido evaluadas en las pruebas.


## **SEMGREP - Reporte de semgrep**

![view_tests](./media/reporte_semgrep.png)

- Total de Hallazgos: 8
- Avisos de Baja Severidad (LOW): 3
- Avisos de Media Severidad (MEDIUM): 5
- Avisos de Alta Severidad (HIGH): 0
- Errores de Confianza Desconocida: 8

1. Falta de Protección Contra Ataques CSRF (LOW)

Se ha detectado que algunos métodos de la aplicación, como AgregarEmpleado y RegistrarAsistencia, no están validando correctamente que las solicitudes provengan de fuentes legítimas. Esto crea una vulnerabilidad a ataques CSRF (Cross-Site Request Forgery), donde un atacante podría modificar datos o realizar acciones no autorizadas sin ser detectado.

Ubicación del problema:

AdminController.cs, línea 57
AsistenciaController.cs, línea 27
EmpleadoController.cs, línea 18

2. Vulnerabilidad por Exposición de Datos (MEDIUM)

Se ha identificado una vulnerabilidad de over-posting en varios métodos, lo que permite que los parámetros de las solicitudes modifiquen más datos de los que deberían. Esto permite a un atacante agregar o manipular datos internos de la aplicación, lo que podría causar alteraciones no deseadas.

Ubicación del problema:

AdminController.cs, líneas 63, 70, 77
EmpleadoController.cs, línea 28

3. Riesgo de Colapso por Expresión Regular (LOW)

Se encontró un uso ineficiente de expresiones regulares en el código JavaScript, específicamente en el archivo jquery.validate.unobtrusive.js. Esto podría generar un problema de ReDoS (Regular Expression Denial of Service), donde un atacante puede provocar un uso excesivo de recursos al enviar entradas diseñadas para colapsar la aplicación.

Ubicación del problema:

jquery.validate.unobtrusive.js, línea 349


 ### **Referencias:**

* Juanjo. (2022, September 20). Qué es SonarCloud y cómo mejora la calidad de tu código. Platzi. https://platzi.com/blog/sonarcloud-mejora-codigo-sast/
* Vergara, S. (2019, February 21). Seguridad continua en tus desarrollos con Snyk. Blog ITDO - Agencia de Desarrollo Web, APPs Y Marketing En Barcelona. https://www.itdo.com/blog/seguridad-continua-en-tus-desarrollos-con-snyk/
* Quickstart | Semgrep. (2024, September 20). Semgrep.dev. https://semgrep.dev/docs/getting-started/quickstart
* .NET test coverage & SonarCloud. (2024). Sonarsource.com. https://docs.sonarsource.com/sonarcloud/enriching/test-coverage/dotnet-test-coverage/

‌


