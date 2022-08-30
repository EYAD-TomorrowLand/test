using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_manager : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("game_play_scene");
    }

    public void close()
    {
        Application.Quit();
    }
}
