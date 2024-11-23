Feature: Validar Home y Páginas No Existentes
  Como administrador
  Quiero validar el acceso a la página principal y manejar errores en páginas inexistentes
  Para asegurar que el sistema funciona correctamente

  Scenario: Acceso a la página principal
    Given estoy en el cliente HTTP
    When realizo una petición GET a "/"
    Then obtengo un código de respuesta exitoso

  Scenario: Acceso a una página inexistente
    Given estoy en el cliente HTTP
    When realizo una petición GET a "/non-existing-page"
    Then obtengo un código de respuesta 404
