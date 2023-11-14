using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelloText : MonoBehaviour
{
    [SerializeField] private GameObject congrats; 

    void Start()
    {
        Congrats(false);                          
    }

    void OnTriggerStay()                          
    {
        Congrats(true);                           
        
    }

    void Congrats(bool state)                     
    {
        congrats.SetActive(state);                
    }
}