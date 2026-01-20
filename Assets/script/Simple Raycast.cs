using UnityEngine;

public class SimpleRaycast : MonoBehaviour
{
    public Transform objToPlace;
    public Camera gameCamera;
    // Update is called once per frame
    void Update()
    {
        Ray ray = gameCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            objToPlace.position = hit.point;
            objToPlace.rotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
        }
    }
}
