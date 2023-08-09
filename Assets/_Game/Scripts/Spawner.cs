using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    protected GameObject obj1, obj2;
    int rand;
    float delayTime;
    float timer = 0;
    private void Start()
    {
        delayTime = 0.3f;
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GameController.Instance.IsState(GameState.Play));
        if(GameController.Instance.IsState(GameState.Play))
        {            
            timer += Time.deltaTime;
            if(timer > delayTime) {
                timer = 0;
                delayTime = Random.Range(0.3f, 1f);
                //spawn theo ti le
                rand = Random.Range(1, 11);
                if (rand <= 4)
                {
                    var GO = Instantiate(obj1, transform.position, Quaternion.identity);
                    GamePlayController.Instance.objList.Add(GO);
                }
                else
                {
                    var GO = Instantiate(obj2, transform.position, Quaternion.identity);
                    GamePlayController.Instance.objList.Add(GO);
                }
            }
            
        }
    }
}
