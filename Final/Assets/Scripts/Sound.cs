using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound 
{
    public AudioClip clip;
    
    public string name; 


    [Range(.1f, .3f)]
    public float pitch;
    [Range(0f, 1f)]
    public float volume;

    [HideInInspector]
    public AudioSource source;

    public bool loop;

}
