﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Via.olgerts.kursadarbs
{
    public class MainMenu : MonoBehaviour
    {
        public void startGame()
        {
            SceneManager.LoadScene(1);
        }
        
    }
}