using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void BackToManuByLosing()
    {
        SceneManager.LoadScene(0);
    }
}
