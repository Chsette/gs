using UnityEngine;
using TMPro;

public class CarbonManager : MonoBehaviour
{
    public static CarbonManager Instance;

    public TextMeshProUGUI totalCarbonCreditText;
    private float totalCarbonCredit = 0;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void AddCarbonCredits(float value)
    {
        totalCarbonCredit += value;
        UpdateUI();
    }

    private void UpdateUI()
    {
        totalCarbonCreditText.text = ((int)totalCarbonCredit).ToString();
    }
}
