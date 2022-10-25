using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{

    [SerializeField] bool isActivate;
    [SerializeField] bool isPlayer;
    [SerializeField] bool isAttacker;
    [SerializeField] bool isHoldBall;

    public bool IsActivate
    {
        get
        {
            return IsActivate;
        }
        set
        {
            isActivate = value;
            if (!value)
            {
                ChangeColor(Color.gray);
                return;
            }
            if (!isPlayer)
            {
                ChangeColor(Color.red);
                return;
            }
            ChangeColor(Color.blue);
        }
    }

    void ChangeColor(Color color)
    {
        gameObject.GetComponent<SpriteRenderer>().color = color;
    }
}
