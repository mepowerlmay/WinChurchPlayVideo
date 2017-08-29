using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinChurchPlayVideo.Common
{

    /// <summary>
    /// 清單類別
    /// </summary>
    public  class ListItem : IDisposable
    {


        /// <summary>
        /// 文字
        /// </summary>
        public string Text { get; set; }


        /// <summary>
        /// 值
        /// </summary>
        public string Value { get; set; }



        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
