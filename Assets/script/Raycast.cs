using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] float dis = 100;
    [SerializeField] LayerMask mask;

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, dis, mask, QueryTriggerInteraction.Ignore))
        {
            MeshRenderer mesh = hit.transform.GetComponent<MeshRenderer>();
            mesh.material.color = Color.blue; // if hit destroy then add points per distance. + only destroy when left button is clicked 
            Debug.DrawLine(ray.origin, hit.point, Color.red);
        }
        else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * dis,  Color.green);
        }
    }
}
// the points should be calculated based on the distance of the target to the player.
// Display the highscore at the end of the round