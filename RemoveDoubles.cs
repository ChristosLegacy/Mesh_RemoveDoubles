using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RemoveDoubles : MonoBehaviour
    {
        Mesh mesh;

        List<Vector3> vertices = new List<Vector3>();
        List<int> triangles = new List<int>();

        Dictionary<Vector3, int> verticesToIndices = new Dictionary<Vector3, int>();

        void Awake()
        {
            vertices = mesh.vertices.ToList();
            triangles = mesh.triangles.ToList();
        }

        /*
        Every time you want to add a Vertex call this Method to do it.
        Then use the returned int for the indices of this Vertex.
        For Example:
        triangle.Add(VertexAdd(new Vector3(0,0,0)))
        triangle.Add(VertexAdd(new Vector3(0,1,0)))
        triangle.Add(VertexAdd(new Vector3(1,1,0)))

        triangle.Add(VertexAdd(new Vector3(0,0,0)))
        triangle.Add(VertexAdd(new Vector3(1,1,0)))
        triangle.Add(VertexAdd(new Vector3(1,0,0)))
        */
        public int VertexAdd(Vector3 vertex)
        {
            if (verticesToIndices.ContainsKey(vertex)) 
                return verticesToIndices[vertex];
        
            verticesToIndices.Add(vertex, verticesToIndices.Count);
            vertices.Add(vertex);
            return verticesToIndices[vertex];
        }
    }
