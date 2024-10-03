using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float clicks;
    public static int level;
    public List<Sprite> upgradeOrder;
    public Image icon;
    public TextMeshProUGUI clicksText;
    public TextMeshProUGUI levelText;
    public void click()
    {
        clicks += Wave.waveMultiplier;
        if (clicks%50)
        {
            upgrade();
        }
    }
    public void upgrade()
    {
        level = (int)(clicks / 50);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame/
    void Update()
    {
        clicksText.text = clicks.ToString();
        levelText.text = level.ToString();
        upgrade();
        if (upgradeOrder.Count>level)
        {
            icon.sprite = upgradeOrder[level];
        }
        
    }
}
// (°ʖ°) <-- timmy