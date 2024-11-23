Feature: Validar múltiples escenarios en Home y otras páginas
  Como administrador
  Quiero validar diferentes casos de uso en la aplicación
  Para asegurar que el sistema funcione correctamente

  Scenario: Acceso a la página principal
    Given estoy en el cliente HTTP
    When realizo una petición GET a "/"
    Then obtengo un código de respuesta exitoso

  Scenario: Acceso a una página inexistente
    Given estoy en el cliente HTTP
    When realizo una petición GET a "/non-existing-page"
    Then obtengo un código de respuesta 404

  Scenario: Acceso a la página de inicio de sesión
    Given estoy en el cliente HTTP
    When realizo una petición GET a "/login"
    Then obtengo un código de respuesta exitoso

  Scenario: Envío de formulario sin datos
    Given estoy en el cliente HTTP
    When realizo una petición POST a "/submit-form" con datos vacíos
    Then obtengo un código de respuesta 400

  Scenario: Acceso a la página de perfil
    Given estoy en el cliente HTTP
    When realizo una petición GET a "/profile"
    Then obtengo un código de respuesta exitoso

  Scenario: Envío de formulario con datos válidos
    Given estoy en el cliente HTTP
    When realizo una petición POST a "/submit-form" con datos válidos
    Then obtengo un código de respuesta exitoso

  Scenario: Eliminación de un registro inexistente
    Given estoy en el cliente HTTP
    When realizo una petición DELETE a "/delete/999"
    Then obtengo un código de respuesta 404

  Scenario: Acceso a la página de configuración
    Given estoy en el cliente HTTP
    When realizo una petición GET a "/settings"
    Then obtengo un código de respuesta exitoso

  Scenario: Actualización de un registro
    Given estoy en el cliente HTTP
    When realizo una petición PUT a "/update/1" con datos válidos
    Then obtengo un código de respuesta exitoso

  Scenario: Consulta de un registro inexistente
    Given estoy en el cliente HTTP
    When realizo una petición GET a "/record/999"
    Then obtengo un código de respuesta 404

  Scenario: Consulta de un registro válido
    Given estoy en el cliente HTTP
    When realizo una petición GET a "/record/1"
    Then obtengo un código de respuesta exitoso

  Scenario: Acceso a una API pública
    Given estoy en el cliente HTTP
    When realizo una petición GET a "/api/public"
    Then obtengo un código de respuesta exitoso

  Scenario: Intento de acceso no autorizado
    Given estoy en el cliente HTTP
    When realizo una petición GET a "/admin"
    Then obtengo un código de respuesta 403

  Scenario: Descarga de un archivo
    Given estoy en el cliente HTTP
    When realizo una petición GET a "/download/file"
    Then obtengo un código de respuesta exitoso

  Scenario: Acceso a una API protegida sin token
    Given estoy en el cliente HTTP
    When realizo una petición GET a "/api/private"
    Then obtengo un código de respuesta 401
