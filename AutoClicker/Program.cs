using System.Runtime.InteropServices;

[DllImport("user32.dll")]
static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, IntPtr dwExtraInfo); // click

[DllImport("user32.dll")]
static extern short GetAsyncKeyState(int vKey); // hotkey

const uint LEFTDOWN = 0x02;
const uint LEFTUP = 0x04;
const int HOTKEY = 0x26; // seta pra cima

bool enableClicker = false;
int clickInterval = 5;

while (true)
{
    if(GetAsyncKeyState(HOTKEY) < 0)
    {
        enableClicker = !enableClicker;
        Thread.Sleep(300);
    }

    if (enableClicker)
    {
        MouseClick();
    }
    Thread.Sleep(clickInterval);
}

void MouseClick()
{
    mouse_event(LEFTDOWN, 0, 0, 0, IntPtr.Zero);

    mouse_event(LEFTUP, 0, 0, 0, IntPtr.Zero);
}