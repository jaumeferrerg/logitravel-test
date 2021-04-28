# logitravel-test

Prueba técnica para Logitravel.

Se ha implementado en C#. En este repositorio se encuentra el proyecto de visual studio.</br>
Se trata de una aplicación de consola. El programa principal crea una series de clientes y les envía mensajes de promoción. Los resultados se muestran en la consola.

## Principales componentes del sistema

### PromotionSender
Permite enviar mensajes de promoción a los usuarios. Para ello, antes de enviar a un usuario concreto averigua de que hotel tiene que hacer la promoción.

### UserRepository y HotelRepository
Permiten almacenar y recuperar usuarios y hoteles. Se han implementado versiones "in-memory" muy sencillas.

### User
Representa a un cliente. <b>User</b> es responsable de hacer llegar un mensaje al cliente a través de un <b>Messenger</b>.<br>
Además, permite saber en que hoteles ha reservado el cliente.

### Hotel
Representa un hotel.

### Messenger
Permite enviar un mensaje a un cliente. Existen dos versiones: SMS y email. Solamente imprimen un mensaje en la consola.

## Diagrama de clases
![alt text](https://github.com/jaumeferrerg/logitravel-test/blob/master/class-diagram.png?raw=true)
