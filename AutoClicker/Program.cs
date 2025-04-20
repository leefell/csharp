using System.Runtime.InteropServices;


class Program
{
    [StructLayout(LayoutKind.Sequential)]
    struct INPUT
    {
        public uint type;
        public MOUSEINPUT mi;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct MOUSEINPUT
    {
        public int dx;
        public int dy;
        public uint mouseData;
        public uint dwFlags;
        public uint time;
        public IntPtr dwExtraInfo;
    }

    [DllImport("user32.dll")]
    static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

    [DllImport("user32.dll")]
    static extern short GetAsyncKeyState(int vKey);

    const uint INPUT_MOUSE = 0;
    const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
    const uint MOUSEEVENTF_LEFTUP = 0x0004;

    const int HOTKEY = 0x26; // seta pra cima
    const int EXITKEY = 0x1B; // ESC

    static bool clickerEnabled = false;
    static CancellationTokenSource? cts;
    static int clickInterval = 50; // milissegundos

    static async Task Main()
    {
        Console.WriteLine("AutoClicker CLI iniciado.");
        Console.WriteLine("Seta pra cima = Ativa/Desativa o clicker");
        Console.WriteLine("ESC = Sair do programa");

        while (true)
        {
            if (GetAsyncKeyState(HOTKEY) < 0)
            {
                clickerEnabled = !clickerEnabled;
                Console.WriteLine(clickerEnabled ? "[ON] Clicker ativado." : "[OFF] Clicker desativado.");

                if (clickerEnabled)
                {
                    cts = new CancellationTokenSource();
                    _ = Task.Run(() => RunClickerLoop(cts.Token));
                }
                else
                {
                    cts?.Cancel();
                }

                await Task.Delay(300); // debounce
            }

            if (GetAsyncKeyState(EXITKEY) < 0)
            {
                Console.WriteLine("Encerrando programa...");
                cts?.Cancel();
                break;
            }

            await Task.Delay(50);
        }
    }

    static async Task RunClickerLoop(CancellationToken token)
    {
        while (!token.IsCancellationRequested)
        {
            DoMouseClick();
            await Task.Delay(clickInterval);
        }
    }

    static void DoMouseClick()
    {
        INPUT[] inputs = new INPUT[2];

        inputs[0].type = INPUT_MOUSE;
        inputs[0].mi.dwFlags = MOUSEEVENTF_LEFTDOWN;

        inputs[1].type = INPUT_MOUSE;
        inputs[1].mi.dwFlags = MOUSEEVENTF_LEFTUP;

        SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
    }
}
