using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonData : MonoBehaviour
{
    [SerializeField] SpriteRenderer player;

    // 押した時に呼ばれる関数
    public void OnClick()
    {
        // Playerの召喚
        PlayerSpawn();

        // ボタンを押せないようにする

        // ゲージを出す

    }

    void PlayerSpawn()
    {
        float y = Random.Range(-0.9f, -1.7f);
        SpriteRenderer pl = Instantiate(player, new Vector3(6.4f,y,0),transform.rotation);
        pl.sortingOrder = (int)(-y * 10);
    }
}
