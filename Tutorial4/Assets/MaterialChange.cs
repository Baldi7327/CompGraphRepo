using UnityEngine;

public class MaterialChange : MonoBehaviour
{
    private Renderer targetRenderer;   // Automatically assigned
    public Material LambertMat;
    public Material AmbientMat;
    public Material SpecularMap;

    void Start()
    {
        // Grab the Renderer component from the same GameObject this script is on
        targetRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            targetRenderer.material = LambertMat;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            targetRenderer.material = AmbientMat;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            targetRenderer.material = SpecularMap;
        }
    }
}
