using System.Collections;
using UnityEngine.AI;
using UnityEngine;
//[RequireComponent(typeof(NavMeshAgent))]
public class move : MonoBehaviour
{
    Vector3 start_point, final_point;
    public Vector3 offset;
    // public Mesh mr;
    //NavMeshAgent agent;
    //public Vector3 temp;
    // Start is called before the first frame update
    void Start()
    {
       // agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        start_point = transform.position;


        final_point = start_point - offset;
        //transform.Rotate(Vector3.right * 90);

    }

    // Update is called once per frame
    void Update()
    {

           transform.position += transform.forward * 600 * Time.deltaTime;
           transform.position -= transform.right * 100 * Time.deltaTime;


        // agent.SetDestination(temp);
        if (transform.position[2] >= final_point[2])
        {
            //mr.enabled(false);
            //Debug.Log("here !!");
            Destroy(gameObject);


        }
    }
    
}
