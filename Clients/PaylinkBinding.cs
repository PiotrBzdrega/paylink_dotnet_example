using System.Runtime.InteropServices;

namespace BlazorEmpty.Clients;

public static partial class PaylinkBinding
{

    // Define the callback delegate (must match C++ signature)
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void BanknoteCallback(int overall_val, int banknote_val, IntPtr user_data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ErrorEventCallback(IntPtr msg, IntPtr user_data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void MainSensorChangeCallback(bool state, IntPtr user_data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void DropSensorChangeCallback(int sensor, IntPtr user_data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ButtonsChangeCallback(int state, int open_edge, int close_edge, IntPtr user_data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void CardDetectionCallback(IntPtr uid, IntPtr user_data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void LoggerCallback(IntPtr msg, IntPtr user_data);

    // Import C++ functions
    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern void createPaylinkSystem(string config_path, LoggerCallback cb, IntPtr user_data);


    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern void destroyPaylinkSystem();

    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern NativeStringHandle getVersion();

    // [LibraryImport("libpaylink.so.0.4.0")]
    // public static partial NativeStringHandle getVersion();


    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern void setnewBanknoteCallbackCtx(BanknoteCallback cb, IntPtr user_data);

    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern int setCardDetectedCallbackCtx(CardDetectionCallback cb, IntPtr user_data);

    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern void setButtonsStateChangeCallbackCtx(ButtonsChangeCallback cb, IntPtr user_data);

    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern void setMainSensorChangeCallbackCtx(MainSensorChangeCallback cb, IntPtr user_data);

    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern void setDropSensorChangeCallbackCtx(DropSensorChangeCallback cb, IntPtr user_data);

    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern int dispenseCoins(int amount);

    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern int getButtonsState();

    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool getMainSensor();

    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern int getLastDropSensor();

    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern void setSensorLed(ushort number, ushort red, ushort green, ushort blue);

    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern void setAllSensorLed(ushort red, ushort green, ushort blue);

    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern void setLED(int number, bool on, int interval_ms);

    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern void setMotor(bool on, int ms);

    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern int dispensedCoins();

    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern NativeStringHandle levelOfCoins();

    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern int currentCredit();

    [DllImport("libpaylink.so.0.4.0", CallingConvention = CallingConvention.Cdecl)]
    public static extern void freeString(IntPtr str);
}
