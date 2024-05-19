using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject ExitGamePrompt;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePrompt();
        }
    }
    
    // Scene Changer
    public void ChangeScene(string sceneName)
    {
        GeneralUseScript.ChangeScene(sceneName);
    }

    //game exit function
    public void QuitGame()
    {
        Debug.Log("Closing Game");
        Application.Quit();
    }

    //toggle visibility of game exit prompt
    public void TogglePrompt()
    {
        if (ExitGamePrompt.activeSelf)
        {
            ExitGamePrompt.SetActive(false);
        }
        else
        {
            ExitGamePrompt.SetActive(true);
        }
    }
}
