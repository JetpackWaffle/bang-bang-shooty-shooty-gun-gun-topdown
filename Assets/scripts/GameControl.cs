using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public float scrollSpeed;
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy (gameObject);
        }
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
