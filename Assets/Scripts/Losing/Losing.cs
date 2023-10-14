using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Losing : MonoBehaviour
{
    private BoxCollider2D coll;
    [SerializeField] private GameObject lose_ui;
    [SerializeField] private GameObject HUD;

    [SerializeField] private AudioSource lose;

    private void Start()
    {
        coll = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            coll.enabled = false;
            lose_ui.SetActive(true);
            HUD.SetActive(false);
            lose.Play();
        }
    }
}
