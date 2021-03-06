using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerScript : MonoBehaviour
{
    public Animator startButton;
    public Animator settingsButton;
    public Animator dialog;

  
    public void OpenSettings()
    {
        startButton.SetBool("isHidden", true);
        settingsButton.SetBool("isHidden", true);
        dialog.enabled = true;
        dialog.SetBool("isHidden", false);
    }

    public void CloseSettings()
    {
        startButton.SetBool("isHidden", false);
        settingsButton.SetBool("isHidden", false);
        dialog.SetBool("isHidden", true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }


}
