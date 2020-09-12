using HierarchyIcons;
using UnityEngine;

public class TestComponent : MonoBehaviour
{
    HierarchyIcon m_hierarchyIcon;

    void Awake()
    {
        m_hierarchyIcon = GetComponent<HierarchyIcon>();
    }

    void OnGUI()
    {
        GUILayout.Box(gameObject.name + " has HierarchyIcon: " + (m_hierarchyIcon != null));
    }
}