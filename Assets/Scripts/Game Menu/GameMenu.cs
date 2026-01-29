using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Game Menu Button handler to load archer game scene 
    public void PlayArcher()
    {
        SceneManager.LoadScene("Archer Scene");
        // Play Sound for button click
    }

    public void PlaySword()
    {
        SceneManager.LoadScene("Sword Scene");
        // Play Sound from audio source
    }

    public void PlaySound(AudioSource audioSource)
    {
        audioSource.Play();
    }




}
