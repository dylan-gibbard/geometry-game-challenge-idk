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






    public void changeColor()
    {
        if(Random.Range(1, 50)==1)
        {
            Debug.Log("<insert supreme color cube only in Ohio here>");
        }
    }
    public void click()
    {
        
        clicks += Wave.waveMultiplier;
        if (clicks>level*50)
        {

            level += 1;
            upgrade();
        }
        changeColor();
    }
    public void upgrade()
    {
        if (level % 5 == 0)
        {
            Wave.waveRef.waveLineUpgRade();
        }
        
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

        if (upgradeOrder.Count>level)
        {
            icon.sprite = upgradeOrder[level];
        }
        
    }
}
// (°ʖ°) <-- timmy