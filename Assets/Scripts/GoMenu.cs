﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoMenu : MonoBehaviour
{
    public void gotoMenu()
    {
        SceneManager.LoadScene(0);
    }
}
