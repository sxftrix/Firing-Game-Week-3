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
            Debug.DrawLine(ray.origin, hit.point, Color.red);

            if (Input.GetMouseButtonDown(0)) 
            {
                Scoring.Instance.ProcessHit(hit);
            }
        }
        else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * dis, Color.green);
        }
    }
}
