using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelNumberScript : MonoBehaviour{

    Text text;
    int sceneIndex;

    void Start () {
        text = GetComponent<Text>();
        sceneIndex = SceneManagement.GetActiveScen().buildIndex;
    }

    void Update(){
        text.text="Level "+ sceneIndex;
    }
}
