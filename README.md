## Descripción del Código - Stop VPN Service

---

#### Descripción en Español:

**Título:** Detener Servicio y Procesos de VPN

**Descripción:**
Este código está diseñado para buscar y detener cualquier instancia en ejecución de un cliente VPN específico, así como también detener el servicio asociado a dicho cliente. Es útil en situaciones donde se desea cerrar el cliente VPN y desactivar su servicio de manera automática.

**Pasos:**
1. **Buscar Procesos VPN:**
   - Utiliza el método `GetProcessesByName` de la clase `Process` para buscar procesos con el nombre del cliente VPN.
   - Recorre cada proceso encontrado y lo cierra utilizando el método `Kill()`.

2. **Detener Servicio de VPN:**
   - Crea un nuevo proceso para ejecutar el comando `net stop nombre_del_servicio` en la línea de comandos.
   - Configura la instancia del proceso para no utilizar la interfaz de usuario (`UseShellExecute = false`) y redirige la salida estándar (`RedirectStandardOutput = true`).
   - Inicia el proceso y espera a que se complete su ejecución mediante `WaitForExit()`.

---

#### Description in English:

**Title:** Stop VPN Service and Processes

**Description:**
This code is designed to search for and terminate any running instances of a specific VPN client, as well as stop the associated VPN service. It's useful in situations where you want to shut down the VPN client and disable its service automatically.

**Steps:**
1. **Search VPN Processes:**
   - Uses the `GetProcessesByName` method of the `Process` class to search for processes with the name of the VPN client.
   - Iterates over each found process and terminates it using the `Kill()` method.

2. **Stop VPN Service:**
   - Creates a new process to execute the `net stop service_name` command in the command line.
   - Configures the process instance to not use the user interface (`UseShellExecute = false`) and redirect standard output (`RedirectStandardOutput = true`).
   - Starts the process and waits for it to complete execution using `WaitForExit()`.

## Note:
This code can be used with other VPN services by replacing "nombre_del_servicio" with the appropriate service name.
