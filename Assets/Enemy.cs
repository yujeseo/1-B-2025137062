using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health = 100;
    public float timer = 1.0f;
    public int AttackPoint = 50;






    // Start is called before the first frame update
    void Start()
    {
        Health += 100;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer <= 0)
        {
            timer = 1;
            Health -= 10;


        }



        if (Input.GetKeyDown(KeyCode.Space))
        {
            Health -= AttackPoint;

        }

        if (Health <= 0)
        {
            Destroy(gameObject);
        }


    }


    void CharacterHit(int Damage)
    {
        Health -= Damage;
    }

    void checkDeath()
    {
        if (Health <= 0)
        {
           
        }

    }


}
