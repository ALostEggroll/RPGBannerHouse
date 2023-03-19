using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreen : MonoBehaviour
{
    public void SetFullscreen (bool isFullScreen) {
        Screen.fullScreen = isFullScreen;
    }
}
