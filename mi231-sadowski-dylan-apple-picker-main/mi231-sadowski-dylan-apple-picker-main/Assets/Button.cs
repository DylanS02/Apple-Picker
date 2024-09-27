using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnButtonClick()
    {
        SceneManager.LoadScene("Scene1");
    }   
}