using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinChurchPlayVideo.Model
{
    /// <summary>
    /// 資料表模型
    /// </summary>
    public class CustomerModel
    {
        public long ID { get; set; }
        public string IsDelete { get; set; }
        public string CustomerName { get; set; }
        public string Area { get; set; }
        public string Idno { get; set; }
        public string VideoAddress { get; set; }
        public string BarcodeNumber { get; set; }
    }
}
