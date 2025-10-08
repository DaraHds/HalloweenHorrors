using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    Animator _animator;
    int direction = 1;
    float timeInDirection;

    public float distanceTime;
    public float speed;
    public int health;
<<<<<<< HEAD
    float dieTime = 1;
    bool isDead = false;
    bool isIdle = false;
    public float idleTime = 2;
=======

>>>>>>> 8ef17e686eb09b41114116e68191e3f68e9e64e4

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        timeInDirection = distanceTime;
        _animator.SetFloat("Move X",direction);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
<<<<<<< HEAD
            if (isIdle && idleTime < 0)
            {
                direction = direction * -1;
                _animator.SetInteger("Direction", direction);
                _animator.SetFloat("Move", 1);
                timeInDirection = distanceTime;
                isIdle = false;
            }
            else if (!isIdle && timeInDirection < 0)
            {
                idleTime = 2;
                isIdle=true;
                _animator.SetFloat("Move", 0);

            }
            if (!isIdle)
            {
                Vector2 pos = transform.position;
                pos.x = pos.x + (speed * Time.deltaTime * direction);
                transform.position = pos;
                timeInDirection -= Time.deltaTime;
            }
            else 
            {
                idleTime -= Time.deltaTime;
            }
        }
        
        else
        {
            dieTime -= Time.deltaTime;
            if (dieTime < 0)
            {
                Destroy(this.gameObject);
            }
=======
            direction = direction * -1;
            _animator.SetInteger("Direction", direction);
            timeInDirection = distanceTime;
>>>>>>> 8ef17e686eb09b41114116e68191e3f68e9e64e4
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
<<<<<<< HEAD
        if (collision.tag == "PlayerProjectile")
        {
            health--;
            if (health <= 0)
            {
                isDead = true;
                _animator.SetBool("Dead", true);
            }
        }
    }

    

=======
        if(collision.tag == "PlayerProjectile")
        {
            health--;
            Debug.Log(health);
        }
    }
>>>>>>> 8ef17e686eb09b41114116e68191e3f68e9e64e4
}
