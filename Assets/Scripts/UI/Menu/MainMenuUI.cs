using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
   [SerializeField] GameObject ControlsPanel;
    private void Awake()
    {
        ControlsPanel.SetActive(false);

    }
    public void PlayClick()
    {
        Loader.Load(1);
    }
    public void ControlsClick()
    {
        ControlsPanel.SetActive(true);
    }
    public void QuitClick()
    {
        Application.Quit();
    }
    public void CloseControlPanel()
    {
        ControlsPanel.SetActive(false);

    }
}
