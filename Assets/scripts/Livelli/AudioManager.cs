using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] GameObject Vol;
    [SerializeField] GameObject Mut;
   
    public void Mute() {
        Vol.SetActive(false);
        Mut.SetActive(true);
        AudioListener.volume = 0;
        
    }

    public void Volume() {
        Vol.SetActive(true);
        Mut.SetActive(false);
        AudioListener.volume = 1;
        
    }
}
