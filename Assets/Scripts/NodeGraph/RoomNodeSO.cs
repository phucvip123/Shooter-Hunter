using UnityEngine;

[CreateAssetMenu(fileName = "RoomNodeSO", menuName = "Scriptable Objects/RoomNodeSO")]
public class RoomNodeSO : ScriptableObject
{
    [HideInInspector] public string id;
    [HideInInspector] public List<string> parentRoomNodeIDList = new List<string>();
    [HideInInspector] public List<string> childRoomNodeIDList = new List<string>();
    [HideInInspector] public RoomNodeSO roomNodeGraph;
    public RoomNodTypeSO roomNodeType;
    [HideInInspector] public RoomNodeTypeListSO roomNodeTypeList;
}
