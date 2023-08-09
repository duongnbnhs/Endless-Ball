using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : Singleton<GameController>
{
    private GameState gameState;
    [SerializeField] GameObject menu;
    private void Start()
    {
        ChangeState(GameState.MainMenu);
        menu.SetActive(true);
    }

    public void ChangeState(GameState gameState)
    {
        this.gameState = gameState;
    }

    public bool IsState(GameState gameState)
    {
        return this.gameState == gameState;
    }
}
