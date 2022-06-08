using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Spawning : MonoBehaviour
{
        [SerializeField]
    private GameObject cubesPrefab;

        [SerializeField]
    private GameObject spheresPrefab;

    [SerializeField]
    private GameObject cylindersPrefab;

    [SerializeField]
    private Toggle _cubeToggle  , _sphereToggle , _cylinderToggle;

    // public static ArrayList cubeArray;
    // public static ArrayList sphereArray;
    // public static ArrayList cylinderArray;
    
    private Renderer cubeRenderer;
    private Renderer sphereRenderer;
    private Renderer cylinderRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // cubeArray = new ArrayList();
        // sphereArray = new ArrayList();
        // cylinderArray = new ArrayList();

        cubeRenderer = cubesPrefab.GetComponent<Renderer>();
        sphereRenderer = spheresPrefab.GetComponent<Renderer>();
        cylinderRenderer = cylindersPrefab.GetComponent<Renderer>();

        _cubeToggle.interactable = false;
        _sphereToggle.interactable = false;
        _cylinderToggle.interactable = false;

    }

    // // Update is called once per frame
    // void Update()
    // {
       
    // }

    public void CreateCube()
    {
        var position = new Vector3(Random.Range(-300.0f, 300), Random.Range(-100.0f, 300), 100);
        GameObject x = Instantiate(cubesPrefab,position, cubesPrefab.transform.rotation);
        // cubeArray.Add(x);
        // _cubeToggle.SetActive(true);
        _cubeToggle.interactable = true;
        
    }

    public void CreateSphere()
    {
        var position = new Vector3(Random.Range(-300.0f, 300), Random.Range(-100.0f, 300), 100);
        GameObject x = Instantiate(spheresPrefab,position, spheresPrefab.transform.rotation);
        // sphereArray.Add(x);
        _sphereToggle.interactable = true;
    }

    public void CreateCylinder()
    {
        var position = new Vector3(Random.Range(-300.0f, 300), Random.Range(-100.0f, 300), 100);
        GameObject x = Instantiate(cylindersPrefab,position, cylindersPrefab.transform.rotation);
        // cylinderArray.Add(x);
        _cylinderToggle.interactable = true;

    }

    public void CubeColor()
    {

        if (_cubeToggle.isOn)
        {
            cubeRenderer.sharedMaterial.SetColor("_Color", Color.red);
        }
        else
        {
            cubeRenderer.sharedMaterial.SetColor("_Color", Color.white);
        }



        // foreach (GameObject item in cubeArray)
        // {
        //     item.GetComponent<Renderer> ().material.color = Color.yellow;            
        // }


        // if (Input.GetButtonUp("CubeButton"))
        // {
        //     foreach (GameObject item in cubeArray)
        //     {
        //         item.GetComponent<Renderer> ().material.color = new Color(0,255,0);         
        //     }
        // }
        // StartCoroutine(Example());
       
    }

     public void SphereColor()
    {
        if (_sphereToggle.isOn)
        {
            sphereRenderer.sharedMaterial.SetColor("_Color", Color.green);
        }
        else
        {
            sphereRenderer.sharedMaterial.SetColor("_Color", Color.white);
        }

        // foreach (GameObject item in sphereArray)
        // {
        //     item.GetComponent<Renderer> ().material.color = Color.yellow;            
        // }
        // StartCoroutine(Example());
        // foreach (GameObject item in sphereArray)
        // {
        //     item.GetComponent<Renderer> ().material.color = new Color(255,0,0);             
        // }
    }

     public void CylinderColor()
    {
        if (_cylinderToggle.isOn)
        {
            cylinderRenderer.sharedMaterial.SetColor("_Color", Color.blue);
        }
        else
        {
            cylinderRenderer.sharedMaterial.SetColor("_Color", Color.white);
        }

        // foreach (GameObject item in cylinderArray)
        // {
        //     item.GetComponent<Renderer> ().material.color = Color.yellow;            
        // }
        // StartCoroutine(Example());
        // foreach (GameObject item in cylinderArray)
        // {
        //     item.GetComponent<Renderer> ().material.color = new Color(255,0,118);            
        // }
    }

    // IEnumerator Example()
    // {
    //     print(Time.time);
    //     yield return new WaitForSeconds(5);
    //     print(Time.time);
    // }

}
