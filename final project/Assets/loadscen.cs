using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class loadscen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Reloadlevel2()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
