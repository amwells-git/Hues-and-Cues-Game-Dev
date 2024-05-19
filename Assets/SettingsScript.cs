using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    public GameObject DisplayDropdown;
    public GameObject DisplayChangePrompt;
    private bool TimerActive = false;
    private float Timer = 30f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerActive)
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                Display.displays[GeneralUseScript.DisplayIndex].Activate();
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (DisplayChangePrompt.activeSelf)
            {
                DisplayChangePrompt.SetActive(false);// slightly different when implementation finished
            }
            else
            {
                GeneralUseScript.ChangeScene("Main Menu");
            }
        }
    }
    
    // Display change
    public void ChangeMonitor()
    {
        int display = DisplayDropdown.GetComponent<TMP_Dropdown>().value;

        if (Display.displays.Length > 1)
        {
            Display.displays[display].Activate();
        }

        TimerActive = true;
        DisplayChangePrompt.SetActive(true);
    }
}
