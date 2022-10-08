using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Loading the Map1
    public void OnclickMap1()
    {
        SceneManager.LoadScene("Map1");
    }

    // Loading the Map2
    public void OnclickMap2()
    {
        SceneManager.LoadScene("Map2");
    }

    // Loading the Map3
    public void OnclickMap3()
    {
        SceneManager.LoadScene("Map3");
    }

    // Loading the Map4
    public void OnClickCampaign()
    {
        SceneManager.LoadScene("Campaign");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
