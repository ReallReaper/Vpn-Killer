using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Buscar procesos que estén ejecutando NordVPN.exe
        Process[] nordVPNs = Process.GetProcessesByName("NordVPN");

        // Cerrar cada instancia en ejecución de NordVPN.exe
        foreach (Process nordVPN in nordVPNs)
        {
            nordVPN.Kill();
        }

        // Detener el servicio de NordVPN
        Process serviceStop = new Process();
        serviceStop.StartInfo.FileName = "cmd.exe";
        serviceStop.StartInfo.Arguments = "/c net stop nordvpn-service";
        serviceStop.StartInfo.UseShellExecute = false;
        serviceStop.StartInfo.RedirectStandardOutput = true;
        serviceStop.Start();
        serviceStop.WaitForExit();
    }
}
