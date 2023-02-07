using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    private AudioSource audioSource;
    [SerializeField]
    private AudioSource gameAudioSource;
    [SerializeField]
    private AudioClip eatSoundClip;
    [SerializeField]
    private AudioClip loseSoundClip;
    [SerializeField]
    private AudioClip winSoundClip;
   

    private void Awake() => audioSource = GetComponent<AudioSource>();

    
    private void OnEnable()
    {
        Game_Events_System.instance.OnEatSound += PlayEatSound;
        Game_Events_System.instance.OnDie += PlayLoseSound;
        Game_Events_System.instance.OnWinPanel += PlayWinSound;
        Game_Events_System.instance.OnDie += StopGameSound;
        Game_Events_System.instance.OnGameOverPanel += StopGameSound;
        Game_Events_System.instance.OnWinPanel += StopGameSound;
    }

    private void OnDisable()
    {
        Game_Events_System.instance.OnEatSound -= PlayEatSound;
        Game_Events_System.instance.OnDie -= PlayLoseSound;
        Game_Events_System.instance.OnWinPanel -= PlayWinSound;
        Game_Events_System.instance.OnDie -= StopGameSound;
        Game_Events_System.instance.OnGameOverPanel -= StopGameSound;
        Game_Events_System.instance.OnWinPanel -= StopGameSound;
    }
    
    
    private void PlayEatSound() => audioSource.PlayOneShot(eatSoundClip);
    private void PlayLoseSound() => audioSource.PlayOneShot(loseSoundClip);
    private void PlayWinSound() => audioSource.PlayOneShot(winSoundClip);
    private void StopGameSound() => gameAudioSource.Stop();


}

