/*Juego de adivinar el numero*/
Este es un minijuego sencillo donde solamente debes adivinar un numero totalmente random entre el 1 y el 100
Tienes 5 intentos, despues de cada uno se te da una pista de que tan lejos estas del numero escondido
El minijuego se reinicia luego de perder, igual puedes tu reiniciarlo cuando quieras

/*Creador*/
Josué Zúñiga Solís
correo: jazs2004105@gmail.com
objetivo: proyecto final de curso de C# (INCOMPLETO)

/*Referencias*/

https://es.vecteezy.com/png/13473794-panel-de-pantalla-de-juegos-en-linea-e-imagen-de-borde-para-jugadores-con-botones-coloridos-decoracion-de-superposicion-de-transmision-en-vivo-con-tonos-femeninos-de-color-rosa-y-azul-elementos-de-transmision-en-vivo-png


/*Avanzado*/
El programa esta creado en C# Winforms .Net, tiene un problema al intentar seguir con los intentos, este se queda en un ciclo haciendo que de 
error al querer obtener información de la funcion txtNumUsuario y ésta no tenga nada ya que elimino todo su contenido en el propio ciclo.
Intente arreglarlo al cerrar el ciclo luego de que marcara cada intento pero esto no funciono ya que al segundo intento este da la 
NullReferenceException (una por fuera del catch ya colocado). al quitar la funcion de eliminar el contenido de txtNumUsuario, el programa encicla
y termina mostrando muchas veces el ultimo MessageBox que apareció