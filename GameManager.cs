using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public int coinCount;
    public int coinGoal;
    public TextMeshProUGUI coinText;
    public GameObject door;
    private bool doorDestroyed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: " + coinCount.ToString();

        if(coinCount == coinGoal)
        {
            doorDestroyed = true;
            Destroy(door);
        }
    }
}
