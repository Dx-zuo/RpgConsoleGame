using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame
{
    class ViewData
    {

        private static char[,] viewResource;
        /// <summary>
        /// 地图保存数据
        /// </summary>
        public static char[,] ViewResource {
            get { return viewResource; }
            set { viewResource = value; }
        }

        private static char[,] viewsource;
        /// <summary>
        /// 展示用地图
        /// </summary>
        public static char[,] Viewsource
        {
            get { return viewsource; }
            set { viewsource = value; }
        }
        
    }
}
