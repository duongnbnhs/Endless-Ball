using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovingObject : GameUnit
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed;
    float x, y;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        OnInit();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.Instance.IsState(GameState.Play))
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(x, y, 0f), speed * Time.deltaTime);
            timer += Time.deltaTime;
            if (timer > 2f)
            {
                OnDespawn();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnDespawn();
        }
    }
    /*private void Despawn()
    {
        //Destroy(gameObject);
        SimplePool.Despawn(this);
    }*/

    public override void OnInit()
    {
        x = Random.Range(-50f, 60f);
        y = Random.Range(-50f, 60f);
        timer = 0;
    }

    public override void OnDespawn()
    {
        SimplePool.Despawn(this);
    }
}
