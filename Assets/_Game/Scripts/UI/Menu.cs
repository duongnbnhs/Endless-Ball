using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    
    public void PlayButton()
    {
        GamePlayController.Instance.StartGame();
    }
}
