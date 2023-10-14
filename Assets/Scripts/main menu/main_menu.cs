using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{

    [SerializeField] private GameObject levelselecthud;
    [SerializeField] private GameObject mainhud;

    [SerializeField] private AudioSource sfx;



    public void startgame()
    {
        mainhud.SetActive(false);
        levelselecthud.SetActive(true);
        sfx.Play();
    }

    public void close_game()
    {
        Application.Quit();
        sfx.Play();
    }

    public void go_back()
    {
        mainhud.SetActive(true);
        levelselecthud.SetActive(false);
        sfx.Play();
    }

    public void open_level1()
    {
        SceneManager.LoadScene(1);
        sfx.Play();
    }

    public void open_level2()
    {
        SceneManager.LoadScene(2);
        sfx.Play();
    }

    public void open_level3()
    {
        SceneManager.LoadScene(3);
        sfx.Play();
    }

    public void open_level4()
    {
        SceneManager.LoadScene(4);
        sfx.Play();
    }

    public void open_level5()
    {
        SceneManager.LoadScene(5);
        sfx.Play();
    }

    public void open_level6()
    {
        SceneManager.LoadScene(6);
        sfx.Play();
    }

    public void open_level7()
    {
        SceneManager.LoadScene(7);
        sfx.Play();
    }

    public void open_level8()
    {
        SceneManager.LoadScene(8);
        sfx.Play();
    }

    public void open_level9()
    {
        SceneManager.LoadScene(9);
        sfx.Play();
    }

    public void open_level10()
    {
        SceneManager.LoadScene(10);
        sfx.Play();
    }

    public void open_level11()
    {
        SceneManager.LoadScene(11);
        sfx.Play();
    }

    public void open_level12()
    {
        SceneManager.LoadScene(12);
        sfx.Play();
    }

    public void open_level13()
    {
        SceneManager.LoadScene(13);
        sfx.Play();
    }
}
