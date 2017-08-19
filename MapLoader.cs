using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapLoader : MonoBehaviour {

    public float WesternPropsPackVotes = 0;
    public float DesertEnviroVotes = 0;
    public float CubethonVotes = 0;
    public float PlatformerVotes = 0;

    public void Start()
    {
        
    }

    void Update()
    {
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

    public void MapChooser()
    {
        if (Time.time >= 10f && DesertEnviroVotes > WesternPropsPackVotes && DesertEnviroVotes > CubethonVotes && DesertEnviroVotes > PlatformerVotes)
        {
            SceneManager.LoadScene("Desert Enviro Example");
        }
    }
}
