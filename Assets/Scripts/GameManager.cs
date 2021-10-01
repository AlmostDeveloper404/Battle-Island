using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance!=null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    public GameObject FinalPanal;
    public void Win()
    {
        FinalPanal.SetActive(true);
    }

    public void Lose()
    {
        FinalPanal.SetActive(true);
    }

    
}
