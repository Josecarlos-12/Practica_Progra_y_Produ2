using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herencia : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Tank tankEnemy = new Tank();

        tankEnemy.life = 10;
        tankEnemy.stamina = 5;

        tankEnemy.MeleeAttack();

        Archer archerEnemy = new Archer();

        archerEnemy.life = 5;
        archerEnemy.stamina = 15;

        archerEnemy.FlyingAttack();
    }


}

class Tank
{
    public int life;

    public int stamina;

    public float attack;

    public string name;

    public void MeleeAttack()
    {
        Debug.Log("MeleeAttack");
    }
}


class Archer : Tank
{
    public void FlyingAttack()
    {
        Debug.Log("RangeAttack");
    }
}
