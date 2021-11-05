using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    
    public void Restart()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
