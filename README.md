### Descripción del Código - Stop NordVPN Service

---

#### Descripción en Español:

**Título:** Detener Servicio y Procesos de NordVPN

**Descripción:**
Este código está diseñado para buscar y detener cualquier instancia en ejecución del cliente NordVPN, así como también detener el servicio asociado a NordVPN. Es útil en situaciones donde se desea cerrar NordVPN y desactivar su servicio de manera automática.

**Pasos:**
1. **Buscar Procesos NordVPN:**
   - Utiliza el método `GetProcessesByName` de la clase `Process` para buscar procesos con el nombre "NordVPN.exe".
   - Recorre cada proceso encontrado y lo cierra utilizando el método `Kill()`.

2. **Detener Servicio de NordVPN:**
   - Crea un nuevo proceso para ejecutar el comando `net stop nordvpn-service` en la línea de comandos.
   - Configura la instancia del proceso para no utilizar la interfaz de usuario (`UseShellExecute = false`) y redirige la salida estándar (`RedirectStandardOutput = true`).
   - Inicia el proceso y espera a que se complete su ejecución mediante `WaitForExit()`.

---

#### Description in English:

**Title:** Stop NordVPN Service and Processes

**Description:**
This code is designed to search for and terminate any running instances of the NordVPN client, as well as stop the associated NordVPN service. It's useful in situations where you want to shut down NordVPN and disable its service automatically.

**Steps:**
1. **Search NordVPN Processes:**
   - Uses the `GetProcessesByName` method of the `Process` class to search for processes with the name "NordVPN.exe".
   - Iterates over each found process and terminates it using the `Kill()` method.

2. **Stop NordVPN Service:**
   - Creates a new process to execute the `net stop nordvpn-service` command in the command line.
   - Configures the process instance to not use the user interface (`UseShellExecute = false`) and redirect standard output (`RedirectStandardOutput = true`).
   - Starts the process and waits for it to complete execution using `WaitForExit()`.
