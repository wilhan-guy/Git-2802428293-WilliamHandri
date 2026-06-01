using UnityEngine;

public class RestartGame : MonoBehaviour
{
    public void LoadNextLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
}
