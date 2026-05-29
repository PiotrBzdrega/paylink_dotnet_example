using System;
using BlazorEmpty.Clients;

namespace BlazorEmpty.Services;

public class PaylinkService
{
    private PaylinkBinding.BanknoteCallback? callback;

    public int CurrentCredit { get; private set; }

    public event Action? CreditChanged;

    public void Initialize()
    {
        PaylinkBinding.createPaylinkSystem("/etc/paylink.conf");

        callback = OnBanknote;

        PaylinkBinding.setnewBanknoteCallback(callback);
    }

    private void OnBanknote(int overall, int banknote)
    {
        CurrentCredit = overall;

        CreditChanged?.Invoke();
    }

    public int DispenseCoins(int amount)
    {
        return PaylinkBinding.dispenseCoins(amount);
    }

    public string GetVersion()
    {
        return PaylinkBinding.getVersion();
    }

    public int GetButtonsState()
    {
        return PaylinkBinding.getButtonsState();
    }

    public string GetSensorsState()
    {
        return PaylinkBinding.getSensorsState();
    }

    public void SetLed(int number, bool on, int interval_ms)
    {
        PaylinkBinding.setLED(number, on, interval_ms);
    }

    public void SetMotor(bool on, int ms)
    {
        PaylinkBinding.setMotor(on, ms);
    }

    public int LevelOfCoins()
    {
        return PaylinkBinding.levelOfCoins();
    }

    public int CurrentCreditSynch()
    {
        return PaylinkBinding.currentCredit();
    }

}
