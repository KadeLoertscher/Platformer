using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationMethods : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void destroySelf()
    {
        Destroy(gameObject);
    }

    public void destroyTransformPlanet()
    {
        Destroy(GameObject.FindGameObjectWithTag("TransformPlanet").gameObject);
    }

    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
