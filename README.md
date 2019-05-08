![EPN](./img/epn.jpg)

# MiPrimerContrato.co

Proyecto correspondiente al primer bimestre de la asignatura **Aplicaciones Distribuidas**

## Acerca de
El presente trabajo consiste en implementar una aplicación distribuida que permita realizar el proceso de contratación del personal.

## Requerimientos

1. Se debe desarrollar un __*cliente*__ y un __*servidor*__.
2. El servidor gestionará la información del personal a contratarse.
3. El cliente tendrá una interfaz de usuario que le permitirá:

    3.1. Conocer cuantas personas han sido contratadas, por tipo de personal (Ocasional, Titular, Invitado, Honorario, Ayudante)
    
    3.2. Si se indica una persona en particular informará el estado (el estado puede ser SOLICITADO, ENTREGA_DOCUMENTOS, VALIDADO y CONTRATADO)
    
    3.3. Permitirá iniciar el proceso de contratación, para lo cual  solicitará datos como nombre, departamento (DEE, DETRI, DACI, DM, DF, DG), título, tipo, CI, y enviará los datos al servidor. Si la persona no existe, el estado será SOLICITADO, si la persona existe, el sistema indicará que no puede iniciarse el proceso.
    
    3.4 Una vez en estado SOLICITADO, permitirá cargar un documento. El sistema permitirá enviar un documento en formato PDF, una vez enviado, pasará a ENTREGA_DOCUMENTOS.
    
    3.5. Una vez en estado ENTREGA_DOCUMENTOS, deberá preguntar si está seguro de contratar, si el cliente dice SI, irá a CONTRATADO, si dice NO irá a VALIDADO. 

![Contratacion](./img/contratacion.jpeg)
