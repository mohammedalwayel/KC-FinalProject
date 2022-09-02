using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class sliderscript : MonoBehaviour
{
    Slider volume;
    AudioSource audoioS; 
    // Start is called before the first frame update
    void Start()
    {
        volume = GetComponent<Slider>();

        audoioS = GameObject.Find("sound controler").GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        audoioS.volume = volume.value; 
    }
}
