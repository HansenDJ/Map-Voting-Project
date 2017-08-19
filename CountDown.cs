using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

    public float timeRemaining = 10f;

    public Text text;

    int time, a;
    float x;
    public bool count;
    public string timeDisp;

    void Start()
    {
        text.text = timeRemaining + " Seconds Remaining";
        time = 4;
        count = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (count == false)
        {
            timeDisp = time.ToString();
            text.text = timeRemaining + " Seconds Remaining";
            x += Time.deltaTime;
            a = (int)x;
            print(a);
            switch (a)
            {
                case 0: GameObject.Find("StartCounter").GetComponent<Text>().text = "10";
                break;
                case 1: GameObject.Find("StartCounter").GetComponent<Text>().text = "9";
                break;
                case 2: GameObject.Find("StartCounter").GetComponent<Text>().text = "8";
                break;
                case 3: GameObject.Find("StartCounter").GetComponent<Text>().text = "7";
                break;
                case 4: GameObject.Find("StartCounter").GetComponent<Text>().text = "6";
                break;
                case 5: GameObject.Find("StartCounter").GetComponent<Text>().text = "5";
                break;
                case 6: GameObject.Find("StartCounter").GetComponent<Text>().text = "4";
                break;
                case 7: GameObject.Find("StartCounter").GetComponent<Text>().text = "3";
                break;
                case 8: GameObject.Find("StartCounter").GetComponent<Text>().text = "2";
                break;
                case 9: GameObject.Find("StartCounter").GetComponent<Text>().text = "1";
                break;
                case 10: GameObject.Find("StartCounter").GetComponent<Text>().text = "0";
                break;
                case 11: GameObject.Find("StartCounter").GetComponent<Text>().enabled = false;
                count = false;
                break;
            }
        }
    }
}
