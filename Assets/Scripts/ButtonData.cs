using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonData : MonoBehaviour
{
    [SerializeField] GameObject player;

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
        Instantiate(player, new Vector3(6.4f,y,0),transform.rotation);
    }
}
