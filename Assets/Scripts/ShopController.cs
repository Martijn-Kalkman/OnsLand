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
        currency += 10;
        UpdateCurrencyText();
        Debug.Log("BuyItem clicked!");

    }

    void UpdateCurrencyText()
    {
        currencyText.text = "Currency: " + currency;
    }
}
