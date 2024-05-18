using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wallet : MonoBehaviour
{
    public static Wallet instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    [SerializeField] Text coinText;

    int maxCoin = 500;
    public float nowCoin = 0;

    int coinSpeed = 6;

    // Start is called before the first frame update
    void Start()
    {
        coinText.text = nowCoin.ToString() + "/" + maxCoin.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isGame && nowCoin <= maxCoin)
        {
            nowCoin += Time.deltaTime * coinSpeed;
            coinText.text = nowCoin.ToString("F0") + "/" + maxCoin.ToString();
        }
    }
}
