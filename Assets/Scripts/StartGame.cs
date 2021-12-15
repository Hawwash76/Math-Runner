using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = startButton.GetComponent<Button>();
		btn.onClick.AddListener(onClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
 	void onClick(){
        SceneManager.LoadScene("GameBeta");
    }
}
