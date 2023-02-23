using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_Final
{
    class RoomTagTypesUtils
    {
        public static List<RoomTagType> GetRoomTagType(ExternalCommandData commandData)
        {
            var doc = commandData.Application.ActiveUIDocument.Document;
            List<RoomTagType> roomTagType = new FilteredElementCollector(doc)
                .OfClass(typeof(FamilySymbol))
                .OfCategory(BuiltInCategory.OST_RoomTags)
                .Cast<RoomTagType>()
                .ToList();
            //Dictionary<int, List<RoomTag>> m_roomWithTags = new Dictionary<int, List<RoomTag>>();

            //foreach (RoomTag roomTag in roomTagType)
            //{
            //    if (m_roomWithTags.ContainsKey(roomTag.Room.Id.IntegerValue))
            //    {
            //        List<RoomTag> tmpList = m_roomWithTags[roomTag.Room.Id.IntegerValue];
            //        tmpList.Add(roomTag);
            //    }
            //}
            return roomTagType;
        }
    }
}
