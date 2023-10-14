using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public bool is_paused = false;
    [SerializeField] private GameObject Pause_UI;

    [SerializeField] private AudioSource pause;
    [SerializeField] private AudioSource select;
    [SerializeField] private AudioSource draw;

    void Update()
    {
        if(Input.GetButtonDown("Pause"))
        {
            is_paused = !is_paused;

            if(is_paused)
            {
                pause_game();
            }

            else
            {
                resume_game();
            }
        }
    }

    public void resume_game()
    {
        Pause_UI.SetActive(false);
        Time.timeScale = 1f;
        is_paused = false;
        select.Play();
    }

    public void pause_game()
    {
        Pause_UI.SetActive(true);
        Time.timeScale = 0f;
        is_paused = true;
        pause.Play();
        draw.Stop();
    }

    public void main_menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        select.Play();
    }

    public void close_game()
    {
        Application.Quit();
        select.Play();
    }

    public void restart_level()
    {
        Time.timeScale = 1f;
        Scene this_scene;
        this_scene = SceneManager.GetActiveScene();
        int scenebuildindex = this_scene.buildIndex;
        SceneManager.LoadScene(scenebuildindex);
        select.Play();
    }

    public void next_level()
    {
        Scene this_scene2 = SceneManager.GetActiveScene();
        int This_build_index2 = this_scene2.buildIndex;
        SceneManager.LoadScene(This_build_index2 + 1);
        select.Play();
    }
}
