using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorMove : MonoBehaviour
{
    public enum TYPE
    {
        PLAYER,
        ENEMY,
    }
    public TYPE type = TYPE.PLAYER;

    float direction;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        switch (type)
        {
            case TYPE.PLAYER:
                // Playerの時の処理
                direction = -1;
                break;

            case TYPE.ENEMY:
                // Enemyの時の処理
                direction = 1;
                break;
        }
        pos = new Vector3(direction, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += pos * Time.deltaTime;
    }
}
