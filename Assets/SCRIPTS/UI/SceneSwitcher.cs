using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void LoadStartScreen() {
        SceneManager.LoadScene("GameStartScreen");
    }
    public void LoadCharacterCreation() {
        SceneManager.LoadScene("CreateCharacter");
    }
    public void LoadWorldMap() {
        SceneManager.LoadScene("WorldMap");
    }
}
