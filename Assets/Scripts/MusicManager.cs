using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public AudioClip audioClip;

    private AudioSource audioSource;
    private static MusicManager instance;
    private static Slider volumeSlider;

    void Awake()
    {
        if (!instance)
            instance = this;
        else
            Destroy(gameObject);

        volumeSlider = FindObjectOfType<Slider>();
        volumeSlider.value = PrefsManager.GetMasterVolume();

        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PrefsManager.GetMasterVolume();
        //volumeSlider.value = PrefsManager.GetMasterVolume();
    }

    // Update is called once per frame
    void Update()
    {
        if (volumeSlider)
            audioSource.volume = volumeSlider.value;
    }

    public void ChangeVolume(float volume)
    {
        PrefsManager.SetMasterVolume(volumeSlider.value);
    }
}
