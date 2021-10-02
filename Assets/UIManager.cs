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
    public Text LevelText;

    public void UpdateHealth(int currentHealth)
    {
        HealthText.text = "x" + currentHealth;
    }

    public void UpdateLevel(int currentLevel)
    {
        LevelText.text = currentLevel.ToString();
    }
}
