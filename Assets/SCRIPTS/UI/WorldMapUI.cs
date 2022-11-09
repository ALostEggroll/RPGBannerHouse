using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMapUI : MonoBehaviour
{
    public GameObject pausePopup;

    public void EnablePausePopup()
    {
        pausePopup.SetActive(true);
    }

    public void DisablePausePopup()
    {
        pausePopup.SetActive(false);
    }
}
