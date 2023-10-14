using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{

    [SerializeField] private AudioSource jump;
    [SerializeField] private AudioSource walk;

    public void jumpsfx()
    {
        if (jump.isPlaying == false)
        {
            jump.Play();
        }
    }

    public void walkfx()
    {
        if (walk.isPlaying == false)
        {
            walk.Play();
        }
    }
}
