using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public string _key;

    void Update()
    {
        if (!_key.Equals(""))
        {
            if (Input.GetKeyDown(_key))
                GetComponent<AudioSource>().Play();
        }
    }

    void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();
    }
}
