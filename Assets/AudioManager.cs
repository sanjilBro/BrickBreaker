using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] private AudioClip[] audioClips;

    void Awake(){
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayImpactSound(int audioIndex){
        // audioSource.clip = impactSound;
        // audioSource.Play();
        audioSource.PlayOneShot(audioSource.clip = audioClips[audioIndex]);
    }
}
