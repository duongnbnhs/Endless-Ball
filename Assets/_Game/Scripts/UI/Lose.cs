using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    public void Replay()
    {        
        GamePlayController.Instance.StartGame();
    }
}
