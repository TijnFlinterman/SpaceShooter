using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// makes so that this script can do sceneManagement or in other words is able to change the scene.

public class DeathScreen : MonoBehaviour
{
    public void ReturnGame()
    // makes a void named ReturnGame so if called the line under it is activated.
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    // if statement is called it will use the SceneManager to set the buildIndex or amount of scenes i have to -2 (the buildIndex works with names or numbers)
    }
}
