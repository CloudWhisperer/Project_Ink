using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit_Door : MonoBehaviour
{
    private BoxCollider2D coll;
    [SerializeField] private GameObject win_ui;
    [SerializeField] private GameObject HUD;

    [SerializeField] private AudioSource win;

    private void Start()
    {
        coll = GetComponent<BoxCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            coll.enabled = false;
            win_ui.SetActive(true);
            HUD.SetActive(false);
            win.Play();
        }
    }

}
