﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;



public class StartButton : MonoBehaviour, IPointerClickHandler

{
    public void OnPointerClick(PointerEventData eventData) // 1
    {
        SceneManager.LoadScene("Game"); // 2
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
