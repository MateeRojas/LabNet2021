En el presente trabajo se hace uso de los Extention Methods, Exceptions y Unit Testing.

Se hace entrega de un programa principal el cual se prueba el funcionamiento de lo aplicado de forma general.
También se entrega un set de pruebas unitarias que prueba el funcionamiendo individual de cada posibilidad del trabajo.

Supuestos:
DividirPorCero: recibirá un entero que intentará dividir por 0. Devuelve si la operacion fue exitosa o no (por motivos de testing).
Dividir: recibirá un entero y un entero nulleable. Devolverá el resultado de la división de estos. Si la division es imposible, devolverá 0 (por motivos de testing).
La división será redondeada ya que no he logrado que devuelva numeros flotantes sin que a la vez permita una división por 0. No creo esto un error fatal ya que
no es el motivo del ejercicio. Tambien al haber hecho el programa de forma que no hay interaccion con el usuario, me deja dividir por una letra. Por este motivo establezco
la precondición de que se le deberá pasar por parámetro un número obligatoriamente.
TirarExcepcion: Hará una acción imposible (en este caso acceder a un index inválido) y arrojará una excepción.
TirarExcepcionPersonalizada: Arrojará una excepción personalizada cuando se la llame.