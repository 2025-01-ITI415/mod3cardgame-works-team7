using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMainScene()
    {
        SceneManager.LoadScene("__Main_Scene__");
    }
    public void LoadProspectorScene()
    {
        SceneManager.LoadScene("__Prospector_Scene__");
    }

    public void LoadGolfScene()
    {
        SceneManager.LoadScene("__Golf_Scene__");
    }
}
