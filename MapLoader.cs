using UnityEngine;
using UnityEngine.SceneManagement;

public class MapLoader : MonoBehaviour
{

    public float ArenaVotes = 0;
    public float DesertEnviroVotes = 0;
    public float CubethonVotes = 0;
    public float PlatformerVotes = 0;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Update()
    {
        OnButtonClick();
    }

    public void OnButtonClick()
    {
        if (ArenaVotes > DesertEnviroVotes && ArenaVotes > CubethonVotes && ArenaVotes > PlatformerVotes)
        {
            SceneManager.LoadScene("Arena Example");
        }
    }
}
