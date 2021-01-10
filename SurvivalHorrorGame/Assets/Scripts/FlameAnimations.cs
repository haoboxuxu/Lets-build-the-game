using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnimations : MonoBehaviour
{

    public int lightNode;
    public GameObject flameLight;

    // Update is called once per frame
    void Update()
    {
        if (lightNode == 0)
        {
            StartCoroutine(animationLight());
        }
    }

    IEnumerator animationLight()
    {
        lightNode = Random.Range(1, 4);
        if (lightNode == 1)
        {
            flameLight.GetComponent<Animation>().Play("TorchAnim1");
        }
        if (lightNode == 2)
        {
            flameLight.GetComponent<Animation>().Play("TorchAnim2");
        }
        if (lightNode == 3)
        {
            flameLight.GetComponent<Animation>().Play("TorchAnim3");
        }

        yield return new WaitForSeconds(0.99f);
        lightNode = 0;
    }
}
