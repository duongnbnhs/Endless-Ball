using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [SerializeField]
    protected Transform pivotPoint;
    [SerializeField]
    protected float rotateSpeed = 40f;
    protected Vector3 rotateAxis = new Vector3(0f, 0f, 1f);
    [SerializeField] GameObject hit1;
    [SerializeField] GameObject hit2;
    [SerializeField] AudioClip clip1;
    [SerializeField] AudioClip clip2;
    void Update()
    {
        if (GameController.Instance.IsState(GameState.Play))
        {
            if(GamePlayController.Instance.life > 0)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    rotateAxis *= -1;
                }
                transform.RotateAround(pivotPoint.position, rotateAxis, rotateSpeed * Time.deltaTime);
            }
            else
            {
                GamePlayController.Instance.LoseGame();
            }
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Score Obj"))
        {
            GamePlayController.Instance.score += 10;
            GamePlayController.Instance.SetScore(GamePlayController.Instance.score);
            ParticlePool.Play(hit1.GetComponent<ParticleSystem>(), transform.position, transform.rotation);
            SoundController.Instance.PlaySound(clip1);
            //Instantiate(hit1, transform.position, transform.rotation);
        }
        if(collision.CompareTag("End Obj"))
        {
            GamePlayController.Instance.life--;
            GamePlayController.Instance.SetLife(GamePlayController.Instance.life);
            ParticlePool.Play(hit2.GetComponent<ParticleSystem>(), transform.position, transform.rotation);
            SoundController.Instance.PlaySound(clip2);
            //Instantiate(hit2, transform.position, transform.rotation);

        }
    }
}
