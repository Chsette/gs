using UnityEngine;
using TMPro;

public class CarbonManager : MonoBehaviour
{
    public static CarbonManager Instance;

    public TextMeshProUGUI totalCarbonCreditText;
    public GameObject biomassLock;
    public GameObject windLock;
    public GameObject nuclearLock;
    public GameObject victoryScreen;
    private float totalCarbonCredit = 0;

    private void Awake()
    {
        victoryScreen.SetActive(false);
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void DisableLock()
    {
        if (totalCarbonCredit >= 100)
        {
            biomassLock.SetActive(false);
        }
        if (totalCarbonCredit >= 850)
        {
            windLock.SetActive(false);
        }
        if (totalCarbonCredit >= 4500)
        { 
            nuclearLock.SetActive(false);
        }
        if (totalCarbonCredit >= 20000)
        {
            victoryScreen.SetActive(true);
        }
    }
    public void AddCarbonCredits(float value)
    {
        totalCarbonCredit += value;
        UpdateUI();
        DisableLock();
    }

    private void UpdateUI()
    {
        totalCarbonCreditText.text = ((int)totalCarbonCredit).ToString();
    }
}
