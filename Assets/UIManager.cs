using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    private void Awake()
    {
        if (instance!=null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    public Text HealthText;

    public void UpdateHealth(int currentHealth)
    {
        HealthText.text = "x" + currentHealth;
    }
}
