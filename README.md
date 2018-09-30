# UnityScenesDemo
Una forma de pasar de una escena a otra por código conservando el estado del juego. Cada escena tiene asociado un modelo que guarda el estado de los objetos en esa escena. El controlador de cada escena guarda el estado de la escena en el modelo cuando hay cambios en ese estado. Los cambios en el modelo se detectan asociando métodos a los eventos `OnValueChange`, `OnTextEndEdit`, etc. Para que el controaldor pueda acceder al modelo se utiliza el patrón [Singleton](https://en.wikipedia.org/wiki/Singleton_pattern).

Una demo en video de este ejemplo está disponible en [Vimeo](https://vimeo.com/292614570)
