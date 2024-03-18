using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ゲーム全体を管理する
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public bool isGame = false;

    // Start is called before the first frame update
    void Start()
    {
        isGame = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
