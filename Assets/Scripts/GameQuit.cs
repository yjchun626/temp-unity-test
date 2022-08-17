using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameQuit : MonoBehaviour
{
    void Update() { if (Input.GetKeyDown(KeyCode.Escape)) Quit(); }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }
}
