using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Player player = null;
    [SerializeField]
    Canvas GameOverCanvas = null;

    // Start is called before the first frame update
    void Start()
    {
        player.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        if (player != null)
        {
            GameOverCanvas.gameObject.SetActive(true);
        }
    }
}
