using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UI : MonoBehaviour 
{
	public Text applesText;
	public Text appleJuiceText;
	public Text powerText;
	public Text moneyText;
	public int applesNum = 100;
	public int appleJuiceNum = 100;
	public int powerNum = 100;
	public int moneyNum = 100;
	void Start () // Use this for initialization
	{
		
	}
	void Update () // Update is called once per frame
	{
		
	}
    void LateUpdate() 
    {
        if (Input.GetKey(KeyCode.Q))
        {
            applesNum += 100;
            applesText.text = "Apples:" + applesNum.ToString();
        }
        if (Input.GetKey(KeyCode.W))
        {
            appleJuiceNum += 100;
            appleJuiceText.text = "Apples Juice:" + appleJuiceNum.ToString();
        }
        if (Input.GetKey(KeyCode.E))
        {
            powerNum += 100;
            powerText.text = "Power:" + powerNum.ToString();
        }
        if (Input.GetKey(KeyCode.R))
        {
            moneyNum += 100;
            moneyText.text = "Money:" + moneyNum.ToString();
        }
    }
}
