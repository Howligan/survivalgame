using UnityEngine;
using System.Collections;

public class SetMeshCollider : MonoBehaviour {

   public MeshCollider meshCol;
   public MeshFilter meshFilt;
	// Use this for initialization
	void Start () {
        meshCol = gameObject.GetComponent<MeshCollider>();
        meshFilt = gameObject.GetComponent<MeshFilter>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void SetMesh()
    {
       // meshCol.sharedMesh = meshFilt.mesh;

    }
}
