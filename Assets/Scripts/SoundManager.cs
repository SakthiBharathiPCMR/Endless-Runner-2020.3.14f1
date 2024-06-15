using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource coinSfx, gameOverSfx;
    public AudioClip coinClip, gameOverClip;
    
    public static SoundManager instance;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        coinSfx = gameObject.AddComponent<AudioSource>();
        gameOverSfx = gameObject.AddComponent<AudioSource>();
        coinSfx.clip = coinClip;
        gameOverSfx.clip = gameOverClip;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayCoin()
    {
        coinSfx.Play();   
    }
    public void PlayGameOver()
    {
        gameOverSfx.Play();
    }
}
