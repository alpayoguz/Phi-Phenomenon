using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhiPhenomena : MonoBehaviour
{
   

    [SerializeField]
    GameObject[] cubes;

    void Start() => StartCoroutine(ChangeColor());
    
        

    IEnumerator  ChangeColor()
    {
        while(true)
        {
            foreach (GameObject cube in cubes)
            {
                Renderer _cubeRenderer = cube.GetComponent<Renderer>();
                _cubeRenderer.material.color = Color.red;
                yield return new WaitForSeconds(0.09f);
                _cubeRenderer.material.color = Color.white;
            }

        }
       
        
    }

}
