using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSound : MonoBehaviour
{
    public AudioClip newSound;
    public AudioSource[] Keys;

    void OnMouseDown()
    {
        foreach (AudioSource item in Keys)
            item.clip = newSound;
    }
}
