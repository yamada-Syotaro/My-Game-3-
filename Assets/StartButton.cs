using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public void OnClick()
    {
        GetComponent<Button>().interactable = false;
        SceneManager.LoadScene("Main");
    }
}
