using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSong : MonoBehaviour
{
    [SerializeField] private AudioSource song;
    // Start is called before the first frame update
    void Start()
    {
        song.Play();
    }

}
