using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("CarMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
