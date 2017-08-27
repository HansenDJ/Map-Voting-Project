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
		// Start WesternPropsPack Scene
        if (Time.time >= 10f && WesternPropsPackVotes > DesertEnviroVotes && WesternPropsPackVotes > CubethonVotes && WesternPropsPackVotes > PlatformerVotes)
        {
            SceneManager.LoadScene("Box and Bottles Shooting");
        }

		// Start DesertEnviro Scene
        if (Time.time >= 10f && DesertEnviroVotes > WesternPropsPackVotes && DesertEnviroVotes > CubethonVotes && DesertEnviroVotes > PlatformerVotes)
        {
            SceneManager.LoadScene("Desert Enviro Example");
        }

		// Start Cubethon Scene
		if (Time.time >= 10f && CubethonVotes > WesternPropsPackVotes && CubethonVotes > DesertEnviroVotes && CubethonVotes > PlatformerVotes)
		{
			SceneManager.LoadScene("Menu");
		}

		// Start 2D Platformer Scene
		if (Time.time >= 10f && PlatformerVotes > WesternPropsPackVotes && PlatformerVotes > DesertEnviroVotes && PlatformerVotes > CubethonVotes)
		{
			SceneManager.LoadScene("MainLevel");
		}
    }
}
