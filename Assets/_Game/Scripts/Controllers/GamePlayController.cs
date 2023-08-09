using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GamePlayController : Singleton<GamePlayController>
{
    [SerializeField] GameObject lvPrefab;
    [SerializeField] GameObject loseCanvas;
    [SerializeField] GameObject menuCanvas;
    [SerializeField] GameObject playCanvas;
    public TMP_Text scrText;
    public TMP_Text lifeText;
    GameObject lv;
    public int score;
    public int life;
    public List<GameObject> objList;
    public void StartGame()
    {        
        GameController.Instance.ChangeState(GameState.Play);
        score = 0;
        life = 3;
        lv = Instantiate(lvPrefab);
        lv.transform.position = Vector3.zero;
        SetLife(life);
        SetScore(score);
        playCanvas.SetActive(true);
        menuCanvas.SetActive(false);
        loseCanvas.SetActive(false);
    }

    public void LoseGame()
    {
        GameController.Instance.ChangeState(GameState.End);
        playCanvas.SetActive(false);
        menuCanvas.SetActive(false);
        loseCanvas.SetActive(true);
        foreach (GameObject obj in objList)
        {
            Destroy(obj);
        }
        Destroy(lv);
    }
    public void SetScore(int score)
    {
        string txt = "Score: " + score;
        scrText.text = txt;
    }
    public void SetLife(int life)
    {
        string txt = "Life: " + life;
        lifeText.text = txt;
    }
}
