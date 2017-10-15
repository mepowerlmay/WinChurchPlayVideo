using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WinChurchPlayVideo.Common;
using WinChurchPlayVideo.Service;

namespace WinChurchPlayVideo.Helper
{
    public class DropDownListHelper
    {
        /// <summary>
        /// 取得所有區域名單
        /// </summary>
        /// <returns></returns>
        public static List<ListItem> GetArea()
        {
            string[] Areas = "中區,東區,西區,南區,北區,西屯區,南屯區,北屯區,豐原區,大里區,太平區,清水區,沙鹿區,大甲區,東勢區,梧棲區,烏日區,神岡區,大肚區,大雅區,后里區,霧峰區,潭子區,龍井區,外埔區,和平區,石岡區,大安區,新社區".Split(',');

            var GroupListItem = new List<ListItem>();

            for (int i = 0; i < Areas.Length; i++)
            {
                GroupListItem.Add(new ListItem { Text = Areas[i], Value = i.ToString() });
            }

            return GroupListItem;
        }

        public static List<ListItem> GetAllNames()
        {

            CustomerService service = new CustomerService();
            
            DataTable dt = service.GetAllName();

            var GroupNameItem = new List<ListItem>();

         
            foreach (DataRow item in dt.Rows)
            {
                GroupNameItem.Add(new ListItem { Value = item[0].ToString(), Text = item[0].ToString() });
            }

            return GroupNameItem;
        }
    }
}
