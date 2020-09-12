using UnityEngine;

namespace HierarchyIcons
{
    public class HierarchyIcon : MonoBehaviour
    {
#if UNITY_EDITOR
        public Texture2D icon;

        [Range(0, 5), Tooltip("Right to left position")]
        public int position;

        [TextArea]
        public string tooltip;
#endif
    }
}