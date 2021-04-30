En el presente trabajo se hace entrega de una aplicacion en capas que se conecta con la base de datos
Northwind a través de Entity Framework. A continuación, aclaraciones respecto al mismo.
Para el punto 4 elegí para mostrar las tablas Products y Employees, para los cuales consideré información reelevante su ID y sus nombres.
Para el 5, elegí la tabla Territories. Se implementaron el Add, Update y Delete. Se hizo utilización de una interface
para su implementacion y en consecuente se debieron usar los tipos genéricos tanto para la entidad como para el ID, ya que el
ID de Territories es varchar. Tambien se implementaron las funciones de la interface a las otra tablas aunque no se hagan uso de ellas
para cumplir con el contrato.
Como ultima aclaración, en la función Update de cada uno, se actualizan los campos que tienen sentido actualizarse, por ejemplo
en Employees se puede actualizar la ciudad pero no el apellido.