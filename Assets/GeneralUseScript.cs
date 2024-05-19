using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GeneralUseScript
{
    // Display to use for game
    public static int DisplayIndex = 0;
    
    // Scene Changer
    public static void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("Loaded Scene " + sceneName);
    }
    
    // Set active display on load
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void Load()
    {
        DisplayIndex = PlayerPrefs.GetInt("DisplayPreference", 0);
        if (Display.displays.Length > 1)
        {
            Display.displays[DisplayIndex].Activate();
        }
    }
    
    // Save active display when changed
    public static void Save()
    {
        PlayerPrefs.SetInt("DisplayPreference", DisplayIndex);
    }
    
}
