using UnityEngine;

namespace AkBoneDynamics
{
    public class AkBDPlaneCollider : AkBDCollider
    {
        private enum Direction
        {
            XAxis,
            YAxis,
            ZAxis,
        }

        [SerializeField] private Direction m_Direction = Direction.YAxis;
        [SerializeField] private bool m_DrawGizmo = true;
        [SerializeField] private float m_GizmoSize = 1f;
        //[SerializeField] private bool m_Debug = true;

        public override (Vector3 newCenter, bool isCollide) CollisionDetection(float radius, Vector3 center)
        {
            // Get plane matrix
            var planeMatrix = Matrix4x4.TRS(Vector3.zero, transform.rotation, Vector3.one);

            // Get plane normal
            var normal = Vector3.zero;
            normal[(int)m_Direction] = 1f;
            normal = planeMatrix.MultiplyPoint3x4(normal);

            float distanceToPoint = Vector3.Dot(normal, (center - transform.position));

            var isCollide = false;
            var newCenter = center;

            if (distanceToPoint - radius < 0)
            {
                isCollide = true;
                newCenter = center - (normal * (distanceToPoint - radius));
            }

            return (newCenter, isCollide);
        }

        void OnDrawGizmos()
        {
            if (m_DrawGizmo)
            {
                Gizmos.matrix = Matrix4x4.TRS(transform.position, transform.rotation, Vector3.one);
                Gizmos.color = Color.yellow;
                
                var normal = Vector3.zero;
                normal[(int)m_Direction] = 1f;

                var squareVertA = Vector3.zero;
                var squareVertB = Vector3.zero;
                var squareVertC = Vector3.zero;
                var squareVertD = Vector3.zero;
                squareVertA[((int)m_Direction + 1) % 3] = m_GizmoSize;
                squareVertA[((int)m_Direction + 2) % 3] = -m_GizmoSize;
                squareVertB[((int)m_Direction + 1) % 3] = m_GizmoSize;
                squareVertB[((int)m_Direction + 2) % 3] = m_GizmoSize;
                squareVertC[((int)m_Direction + 1) % 3] = -m_GizmoSize;
                squareVertC[((int)m_Direction + 2) % 3] = m_GizmoSize;
                squareVertD[((int)m_Direction + 1) % 3] = -m_GizmoSize;
                squareVertD[((int)m_Direction + 2) % 3] = -m_GizmoSize;

                Gizmos.DrawLine(Vector3.zero, normal * m_GizmoSize);
                Gizmos.DrawLine(squareVertA, squareVertB);
                Gizmos.DrawLine(squareVertB, squareVertC);
                Gizmos.DrawLine(squareVertC, squareVertD);
                Gizmos.DrawLine(squareVertD, squareVertA);
                Gizmos.DrawLine(squareVertA, squareVertC);
                Gizmos.DrawLine(squareVertB, squareVertD);

                Gizmos.matrix = Matrix4x4.identity;
            }
        }
    }
}