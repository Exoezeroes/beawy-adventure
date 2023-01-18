using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScripts : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Applicated Quitted!");
    }
}
