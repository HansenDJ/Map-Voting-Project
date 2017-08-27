using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MapLoader : MonoBehaviour {

    public float WesternPropsPackVotes = 0;
    public float DesertEnviroVotes = 0;
    public float CubethonVotes = 0;
    public float PlatformerVotes = 0;
    public Text WesternPropsPackNum;
    public Text DesertEnviroNum;
    public Text CubethonNum;
    public Text PlatformerNum;
    //float Votes01;
    //int votes, v;

    public void Start()
    {
        
    }

    public void Update()
    {
        NumberOfVotes();
        MapChooser();
    }
    
    public void WesternPropsPackClick ()
    {
        WesternPropsPackVotes++;
    }

    public void DesertEnviroClick ()
    {
        DesertEnviroVotes++;
    }

    public void CubethonClick ()
    {
        CubethonVotes++;
    }

    public void PlatformerClick ()
    {
        PlatformerVotes++;
    }

    public void NumberOfVotes()
    {
		WesternPropsPackNum.text = WesternPropsPackVotes.ToString();
        DesertEnviroNum.text = DesertEnviroVotes.ToString();
        CubethonNum.text = CubethonVotes.ToString();
        PlatformerNum.text = PlatformerVotes.ToString();
    }

    public void MapChooser()
    {
        if (Time.time >= 10f && WesternPropsPackVotes > DesertEnviroVotes && WesternPropsPackVotes > CubethonVotes && WesternPropsPackVotes > PlatformerVotes)
        {
            SceneManager.LoadScene("Box and Bottles Shooting");
        }

        if (Time.time >= 10f && DesertEnviroVotes > WesternPropsPackVotes && DesertEnviroVotes > CubethonVotes && DesertEnviroVotes > PlatformerVotes)
        {
            SceneManager.LoadScene("Desert Enviro Example");
        }
    }
}
