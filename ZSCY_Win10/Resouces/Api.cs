﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZSCY_Win10.Resource
{
    public class Api
    {
        /// <summary>
        /// 原创重邮接口，参数page size
        /// </summary>
        public const string yuanchuang_api = "http://hongyan.cqupt.edu.cn/cyxbsMobile/index.php/Home/WelcomeFreshman/cquptOriginal";

        /// <summary>
        /// 最美重邮接口，参数page size
        /// </summary>
        public const string zuimei_api = "http://hongyan.cqupt.edu.cn/cyxbsMobile/index.php/Home/WelcomeFreshman/cquptView";

        /// <summary>
        /// 优秀教师接口，参数page size
        /// </summary>
        public const string youxiujiaoshi_api = "http://hongyan.cqupt.edu.cn/cyxbsMobile/index.php/Home/WelcomeFreshman/outstandingTeacher";

        /// <summary>
        /// 优秀学子接口，参数page size
        /// </summary>
        public const string youxiuxuezi_api = "http://hongyan.cqupt.edu.cn/cyxbsMobile/index.php/Home/WelcomeFreshman/outstandingStudent";
        /// <summary>
        /// 宿舍情况接口，参数page size
        /// </summary>
        public const string susheqinkuang_api = "http://hongyan.cqupt.edu.cn/cyxbsMobile/index.php/Home/WelcomeFreshman/dormitoryIntroduction";
        /// <summary>
        /// 日常生活接口，参数page size
        /// </summary>
        public const string richangshenghuo_api = "http://hongyan.cqupt.edu.cn/cyxbsMobile/index.php/Home/WelcomeFreshman/daylyLife";
        /// <summary>
        /// 周边美食接口，参数page size
        /// </summary>
        public const string zhoubianmeishi_api = "http://hongyan.cqupt.edu.cn/cyxbsMobile/index.php/Home/WelcomeFreshman/surroundingFood";
        /// <summary>
        /// 周边美景接口，参数page size
        /// </summary>
        public const string zhoubianmeijing_api = "http://hongyan.cqupt.edu.cn/cyxbsMobile/index.php/Home/WelcomeFreshman/surroundingView";

        public const string AddRemindApi = @"http://hongyan.cqupt.edu.cn/cyxbsMobile/index.php/Home/Person/addTransaction";
        public const string GetRemindApi = @"http://hongyan.cqupt.edu.cn/cyxbsMobile/index.php/Home/Person/getTransaction";
        public const string DeleteRemindApi = @"http://hongyan.cqupt.edu.cn/cyxbsMobile/index.php/Home/Person/deleteTransaction";
        public const string EditRemindApi = @"http://hongyan.cqupt.edu.cn/cyxbsMobile/index.php/Home/Person/editTransaction";

        public const string StartPageImagApi = @"http://hongyan.cqupt.edu.cn/cyxbsMobile/index.php/Home/Photo/showPicture";
    }
}
