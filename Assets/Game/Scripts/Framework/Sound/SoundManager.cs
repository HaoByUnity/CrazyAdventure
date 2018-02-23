using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    private static SoundManager instance;
    public static SoundManager Instance
    {
        get { return instance; }
    }
    public string ResourceDir = "Sounds";
    AudioSource audioSource;
    void Awake()
    {
        instance = this;
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.playOnAwake = false;
    }
    public bool Mute
    {
        get { return audioSource.mute; }
        set
        {
            audioSource.mute = value;
            PlayerPrefs.SetInt("Mute", value ? 1 : 0);
        }
    }
    public float BGVolume
    {
        get { return audioSource.volume; }
        set { audioSource.volume = value; }
    }
    public void PlayBGM(string name)
    {
        string path = ResourceDir + "/" + name;
        AudioClip ac = Resources.Load<AudioClip>(path);
        audioSource.clip = ac;
        audioSource.Play();
    }
    public void StopBGM()
    {
        audioSource.clip = null;
        audioSource.Stop();
    }
    public void PlayAudio(string name)
    {
        string path = ResourceDir + "/" + name;
        AudioClip ac = Resources.Load<AudioClip>(path);
        AudioSource.PlayClipAtPoint(ac, Vector2.zero);
    }
	void Start () {
		
	}
	void Update () {
		
	}
}
