using UnityEngine;
using TMPro;

public class ShopController : MonoBehaviour
{
    public TMP_Text currencyText;

    private int currency = 10;

    void Start()
    {
        UpdateCurrencyText();
    }

    public void BuyItem()
    {
        if (currency >= 10)
        {
            currency -= 10;
            UpdateCurrencyText();
            Debug.Log("BuyItem clicked!");
        }
        else
        {
            Debug.LogError("You are out of currency!");
        }
    }

    public void SellItem()
    {
        currency += 10;
        UpdateCurrencyText();
        Debug.Log("SellItem clicked!");
    }

    void UpdateCurrencyText()
    {
        currencyText.text = "Currency: " + currency;
    }
}
